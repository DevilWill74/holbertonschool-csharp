using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int> ();
        foreach (KeyValuePair<string, int> value in myDict) {
            int newValue = value.Value * 2;
            newDict.Add(value.Key, newValue);
        }
        return newDict;
    }
}