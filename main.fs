module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here
    if List.isEmpty lst
    then 1
    else List.head lst * prod (List.tail lst)

// Problem 2
let rec map f (lst:int list) =
    // write your solution here
    if List.isEmpty lst
    then []
    else f (List.head lst) :: map f (List.tail lst)

// Problem 3
let rec odd (lst:int list) =
    // write your solution here
    if List.isEmpty lst
    then lst
    elif List.head lst % 2
        then List.head lst :: odd (List.tail lst)

// Problem 4
let rec filter f lst =
    // write your solution here
    if List.isEmpty lst
    then lst
    elif f List.head = true
        then List.head lst :: filter f (List.tail lst)
