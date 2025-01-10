
﻿using System;

namespace Text
{
    ///<summary>Str Class</summary>
    public class Str
    {
        ///<summary>IsPalindrome method: returns True if a string is a palindrome or False if it’s not.</summary>
        public static bool IsPalindrome(string s)
        {
            string lowerCase = s.ToLower();
            lowerCase = lowerCase.Replace(" ", String.Empty);
            lowerCase = lowerCase.Replace(":", String.Empty);
            lowerCase = lowerCase.Replace(",", String.Empty);
            lowerCase = lowerCase.Replace(".", String.Empty);
            if (lowerCase.Length <= 1)
            {
                return true;
            }
            else
            {
                if (lowerCase[0] != lowerCase[lowerCase.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(lowerCase.Substring(1, lowerCase.Length - 2));
                }
            }
        }
    }
}
