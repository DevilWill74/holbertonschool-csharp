using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        //convert list into hashset to have all uniq values
        HashSet<int> uniql1 = new HashSet<int>(list1);
        HashSet<int> uniql2 = new HashSet<int>(list2);
        uniql1.IntersectWith(uniql2);
        List<int> commonelem = new List<int>();
        foreach (var item in uniql1)
        {
            commonelem.Add(item);
        }
        return commonelem;
    }
}
