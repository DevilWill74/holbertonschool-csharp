using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> uniqL1 = list1.FindAll(item => !list2.Contains(item));
        List<int> uniqL2 = list2.FindAll(item => !list1.Contains(item));
        // taking both lists and find the items that are present in one of them but not both
        // (=>) represents lambda operator and/or a separator of a member name and the member implementation in an expression body definition
        uniqL1.AddRange(uniqL2);
        uniqL1.Sort();
        return uniqL1;
    }
}
