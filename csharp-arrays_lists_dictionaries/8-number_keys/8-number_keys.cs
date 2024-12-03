using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        Dictionary<string, string>.KeyCollection keys = myDict.Keys;
        int nkeys = keys.Count;
        return nkeys;
    }
}
