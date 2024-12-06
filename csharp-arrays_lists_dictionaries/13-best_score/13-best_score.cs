using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string keyName = "0";
        if (myList.Count <= 0){
                return "None";
            }

        foreach (KeyValuePair<string, int> kpv in myList) {
            int maxVal = myList.Values.Max();
            if (kpv.Value == maxVal) {
                keyName = kpv.Key;
            }
        }
        return keyName;
    }
}
