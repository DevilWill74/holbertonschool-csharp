using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0; // Return 0 if the list is empty
        }

        int value = myLList.First.Value;
        myLList.RemoveFirst();
        return value;
    }
}
