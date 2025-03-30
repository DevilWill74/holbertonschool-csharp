using System;
using System.Text;

/// <summary> Queue Class </summary>
/// <typeparam name="T"> Template/Type of elements </typeparam>
class Queue<T>
{
    public int count;
    public Node tail { get; set; }
    public Node head { get; set; }

    /// <summary> returns the Queue’s type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Method that creates a new Node and adds it to the end of the queue </summary>
    public void Enqueue(T element)
    {
        Node node = new Node(element);
        node.value = element;

        if (head == null)
        {
            node.next = null;
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node; // Add the new node at the end of the queue
            tail = node;
        }
        count += 1;
    }

    /// <summary> Method Count </summary>
    /// <returns> Number of nodes in the queue </returns>
    public int Count()
    {
        return count;
    }

    /// <summary> Node Class </summary>
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// removes the first node in the queue and returns its value
    /// </summary>
    /// <returns> node value </returns>
    public T Dequeue()
    {
        if (head == null && tail == null)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }

        Node node = head;
        T Fvalue;
        if (node.next == null)
        {
            Fvalue = node.value;
            count -= 1;
            head = null;
            tail = null;
        }
        else
        {
            while (node.next != tail)
            {
                node = node.next;
            }
            Fvalue = tail.value;
            count -= 1;
            tail = node;
            node.next = null;
        }

        return Fvalue;
    }

    /// <summary>
    /// returns value without removing the node
    /// </summary>
    /// <returns> value of the first node of the queue </returns>
    public T Peek()
    {
        if (head == null && tail == null)
        {
            System.Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node node = tail;
        return node.value;

    }

    /// <summary>
    /// prints the queue, starting from the head
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            System.Console.WriteLine("Queue is empty");
        }

        Node node = head;
        while (node != null)
        {
            System.Console.WriteLine(node.value);
            node = node.next;
        }
    }

    /// <summary>
    /// Concatenates all values in the queue if the queue is of type String or Char.
    /// </summary>
    /// <returns>The concatenated string or null.</returns>
    public string Concatenate()
    {
        if (head == null)
        {
            System.Console.WriteLine("Queue is empty");
            return null;
        }

        Type queueType = CheckType();
        if (queueType != typeof(string) && queueType != typeof(char))
        {
            System.Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        StringBuilder sb = new StringBuilder();
        Node node = head;
        while (node != null)
        {
            sb.Append(node.value);
            node = node.next;
        }

        return sb.ToString();
    }
}
