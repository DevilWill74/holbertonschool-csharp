using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        if (size < 0)
        {
            return linkedList; // Return an empty list if size is negative
        }

        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
            Console.WriteLine(i);
        }

        return linkedList;
    }
}
