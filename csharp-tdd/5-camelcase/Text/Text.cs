﻿using System;

namespace Text
{
    ///<summary>Str Class</summary>
    public class Str
    {
        ///<summary>CamelCase method: determines how many words are in a string.</summary>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int wordCount = 1;
            foreach (char letter in s)
            {
                if (Char.IsUpper(letter))
                {
                    wordCount += 1;
                }
            }
            return wordCount;
        }
    }
}