module Trees

    type 'T tree = 
        | Tree of 'T * 'T tree * 'T tree
        | Leaf of 'T

    let testTree = Tree("1", Tree("2", Leaf "a", Leaf "b"), Leaf "c")