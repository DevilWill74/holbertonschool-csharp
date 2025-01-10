﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Str Class</summary>
    public class Str
    {
        ///<summary>UniqueChar method: returns the index of the first non-repeating character of a string.</summary>
        public static int UniqueChar(string s)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 1); 
                }
                else
                {
                    dic[s[i]] +=1;
                }
            }
            for (int i = 0; i <s.Length; i++)
            {
                if (dic[s[i]]==1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}