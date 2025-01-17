using System;
using System.Collections.Generic;

/// <summary>Class Object.</summary>
class Obj
{
/// <summary>method that returns True if the object is an
/// instance of, or if the object is an instance of a class
/// that inherited from, Array, otherwise return False.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return typeof(Array).IsAssignableFrom(obj.GetType());
    }
}
