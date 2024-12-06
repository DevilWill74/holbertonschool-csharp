using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> newList = new List<string> ();
        newList = myDict.Keys.ToList();
        newList.Sort();

        foreach (var key in newList) {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}