# 0x0A. C# - Generics
In this project, we will implement a Queue in C# with a singly linked list and generics. I'm **not** allowed to use `System.Collections` or `System.Collections.Generic` for this project.

## Tasks

### 0. Queue
Create a new class called  `Queue<T>`.

-   `Queue<T>`  should not inherit from other classes or interfaces.
-   Within  `Queue<T>`, create a new method  `CheckType()`  that returns the Queue’s type.
-   You are  **not**  allowed to use  `System.Collections`  or  `System.Collections.Generic`  for this project.
-   **NOTE:**  Your file name for this task will be  `queue.cs`  _not_  `0-queue.cs`  because we will be using this file in subsequent tasks.
-   Directory:  [`0-queue/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/0-queue)

**Expected Output using [`0-main`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x0A-csharp-generics/0-queue/0-main.cs):**
```
Titania792@ubuntu:~/0x0A-csharp-generics/0-queue$ dotnet run
myStrQ Queue Type: System.String
myObjQ Queue Type: System.Object
Titania792@ubuntu:~/0x0A-csharp-generics/0-queue$

```

### 1. Enqueue

Based on  `0-queue`, within  `Queue<T>`, create a public class called  `Node`  with the following properties:

-   `value`: can be of any type, set its initial value to  `null`
-   `next`: must be an object of type  `Node`, set its initial value to  `null`
-   Define a constructor that takes a  `value`  for a new  `Node`  as its only parameter and sets it

Within  `Queue<T>`, add the following properties:

-   `head`: must be an object of type  `Node`
-   `tail`: must be an object of type  `Node`
-   `count`: type  `int`

Add a new method  `Enqueue()`  to the class  `Queue`  that creates a new  `Node`  and adds it to the end of the queue.

-   If the queue is empty, the method should make the new node the head of the queue
-   `count`  should update every time a new node is added

Add a new method  `Count()`  to the class that returns the number of nodes in the Queue.
-   Directory:  [`1-enqueue/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/1-enqueue)

**Expected Output using [`1-main`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x0A-csharp-generics/1-enqueue/1-main.cs):**
```
Titania792@ubuntu:~/0x0A-csharp-generics/1-enqueue$ dotnet run
Number of nodes in queue: 1
Number of nodes in queue: 2
----------
Number of nodes in queue: 3
Number of nodes in queue: 4
Titania792@ubuntu:~/0x0A-csharp-generics/1-enqueue$

```

### 2. Dequeue

Based on  `1-enqueue`, add a new method  `Dequeue()`  to the class  `Queue<T>`  that removes the first node in the queue and returns its value.

-   If the queue is empty, the method should write  `Queue is empty`  to the console and return the default value of the parameter’s type
-   Directory:  [`2-dequeue/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/2-dequeue)

**Expected Output using [`2-main`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x0A-csharp-generics/2-dequeue/2-main.cs):**
```
Titania792@ubuntu:~/0x0A-csharp-generics/2-dequeue$ dotnet run
Number of nodes in queue: 2
First value: 100
Number of nodes in queue: 1
----------
Number of nodes in queue: 1
First value: 9.8
Number of nodes in queue: 0
Queue is empty
First value: 0
Titania792@ubuntu:~/0x0A-csharp-generics/2-dequeue$

```

### 3. Peek

Based on  `2-dequeue`, add a new method  `Peek()`  to the class  `Queue<T>`  that returns the value of the first node of the queue without removing the node.

-   If the queue is empty, the method should write  `Queue is empty`  to the console and return the default value of the parameter’s type
-   Directory:  [`3-peek/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/3-peek)

**Expected Output using [`3-main`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x0A-csharp-generics/3-peek/3-main.cs):**
```
Titania792@ubuntu:~/0x0A-csharp-generics/3-peek$
First value: 100
Number of nodes in queue: 3
----------
Queue is empty
First value:
Titania792@ubuntu:~/0x0A-csharp-generics/3-peek$

```

### 4. Print

Based on  `3-peek`, add a new method  `Print()`  to the class  `Queue<T>`  that prints the queue, starting from the head.

-   If the queue is empty, the method should write  `Queue is empty`  to the console
-   Directory:  [`4-print/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/4-print)

**Expected Output using [`4-main`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/4-print):**
```
Titania792@ubuntu:~/0x0A-csharp-generics/4-print$
hello
holberton
school
----------
Queue is empty
Titania792@ubuntu:~/0x0A-csharp-generics/4-print$

```

### 5. Concatenate


Based on  `4-print`, create a method  `Concatenate()`  that concatenates all values in the queue only if the queue is of type  `String`  or  `Char`.

-   If queue is empty, print  `Queue is empty`  and return  `null`
-   If the queue is not of type  `String`  or  `Char`, print  `Concatenate() is for a queue of Strings or Chars only.`  to the console and return  `null`
-   Directory:  [`5-concatenate/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x0A-csharp-generics/5-concatenate)

**Expected Output using [`5-main`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x0A-csharp-generics/5-concatenate/5-main.cs):**

```
Titania792@ubuntu:~/0x0A-csharp-generics/5-concatenate$
hello holberton school
----------
Queue is empty
----------
abc
Titania792@ubuntu:~/0x0A-csharp-generics/5-concatenate$

```