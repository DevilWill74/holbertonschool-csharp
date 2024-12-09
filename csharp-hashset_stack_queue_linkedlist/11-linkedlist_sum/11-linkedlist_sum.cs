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
}
