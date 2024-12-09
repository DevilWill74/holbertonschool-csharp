using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= myLList.Count)
        {
            return 0; // Return 0 if the index is out of range
        }

        int index = 0;
        foreach (int value in myLList)
        {
            if (index == n)
            {
                return value;
            }
            index++;
        }

        return 0; // This will not be reached as index check is performed above
    }

    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        foreach (int value in myLList)
        {
            sum += value;
        }
        return sum;
    }

    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.First == null || myLList.First.Value >= n)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        LinkedListNode<int> current = myLList.First;
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }

        myLList.AddAfter(current, newNode);
        return newNode;
    }

    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return; // Do nothing if index is out of range
        }

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index)
            {
                myLList.Remove(current);
                return;
            }
            current = current.Next;
            currentIndex++;
        }
    }
}
