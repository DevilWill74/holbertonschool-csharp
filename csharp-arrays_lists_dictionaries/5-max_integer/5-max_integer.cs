using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int len = myList.Count;
        if (len == 0 || myList == null)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        
        myList.Sort();
        return myList[len -1];

    }
}
