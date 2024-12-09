using System;
using System.Linq;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var uniqlist = myList.Distinct().ToList();
        int result = 0;
        for (int i = 0; i < uniqlist.Count; i++)
            result = result + uniqlist[i];
        return result;
    }
}
