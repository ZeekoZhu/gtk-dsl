module CodeGen.Model

open System
open System.Reflection

type BindableProperty =
    { Name: string
      ValueType: string
      Deprecated: bool }

type BindableEvent =
    { Name: string
      EventArgType: string
      Deprecated: bool }

type BindableWidget =
    { Name: string
      HasVoidCtor: bool
      Events: BindableEvent list
      Properties: BindableProperty list }

let isGtkPropAttr (attr: CustomAttributeData) =
    attr.AttributeType.IsAssignableTo typeof<GLib.PropertyAttribute>

let getAllDeclaredProps (t: Type) =
    t.GetProperties(
        BindingFlags.Public
        ||| BindingFlags.Instance
        ||| BindingFlags.DeclaredOnly
    )
    |> List.ofSeq

let getAllProperties (t: Type) =
    let declared = getAllDeclaredProps t

    let declaredNames =
        declared |> Seq.map (fun x -> x.Name) |> Set

    t.GetProperties(BindingFlags.Public ||| BindingFlags.Instance)
    |> Seq.filter (fun prop -> (declaredNames.Contains prop.Name) |> not)
    |> Seq.append declared
    |> Seq.filter
        (fun prop ->
            prop.GetCustomAttribute<GLib.PropertyAttribute>(false)
            <> null)
    |> Seq.filter (fun prop -> prop.CanWrite && prop.CanRead)
    |> Seq.map
        (fun prop ->
            { Name = prop.Name
              Deprecated =
                  prop.GetCustomAttribute<ObsoleteAttribute>(true)
                  <> null
              ValueType = prop.PropertyType.FullName })

let getAllEvents (t: Type) =
    t.GetEvents(BindingFlags.Public ||| BindingFlags.Instance)
    |> Seq.filter (fun event -> event.EventHandlerType.Namespace = "Gtk")
    |> Seq.map
        (fun event ->
            let addMethod = event.GetAddMethod(false)

            if addMethod <> null then
                let paramTypes = addMethod.GetParameters()

                if paramTypes.Length > 0 then
                    Some
                    <| (event,
                        paramTypes.[0].ParameterType.GetMethod(
                            "Invoke"
                        )
                            .GetParameters().[1])
                else
                    None
            else
                None)
    |> Seq.choose id
    |> Seq.map
        (fun (event, argType) ->
            { Name = event.Name
              Deprecated =
                  event.GetCustomAttribute<ObsoleteAttribute>(true)
                  <> null
              EventArgType = argType.ParameterType.FullName })

let isHasVoidCtor (t: Type) =
    t.GetConstructor(BindingFlags.Public ||| BindingFlags.Instance, null, Array.empty, Array.empty)
    <> null

let getBindingInfo (t: Type) =
    { Name = t.Name
      HasVoidCtor = isHasVoidCtor t
      Events = getAllEvents t |> List.ofSeq
      Properties = getAllProperties t |> List.ofSeq }
