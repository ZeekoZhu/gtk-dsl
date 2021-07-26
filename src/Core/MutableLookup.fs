module internal Gtk.DSL.MutableLookup

open System.Collections.Generic

type MutableLookup<'key, 'value when 'key: equality>(elements: 'value seq, keySelector: 'value -> 'key) =
    let dict = Dictionary<'key, Queue<'value>>()

    let init () =
        for el in elements do
            let key = keySelector el
            let exists, queue = dict.TryGetValue key

            if exists then
                queue.Enqueue el
            else
                let queue = Queue()
                queue.Enqueue el
                dict.Add(key, queue)

    let enumerator () =
        let seq = dict |> Seq.collect (fun x -> x.Value)
        seq.GetEnumerator()

    do init ()

    member this.TryPop(key: 'key) =
        let exists, queue = dict.TryGetValue key

        if exists then
            queue.Dequeue() |> Some
        else
            None

    interface IEnumerable<'value> with
        member this.GetEnumerator() : IEnumerator<'value> = enumerator ()

        member this.GetEnumerator() : System.Collections.IEnumerator =
            enumerator () :> System.Collections.IEnumerator
