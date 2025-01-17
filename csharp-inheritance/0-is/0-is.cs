using System;
using System.Collections.Generic;

/// <summary>Class Object.</summary>
class Obj
{
    /// <summary>Method that returns True if the object is an int, otherwise False.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}
