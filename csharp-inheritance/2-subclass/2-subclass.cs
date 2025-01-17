using System;
using System.Collections.Generic;

/// <summary>Class Object.</summary>
class Obj
{
/// <summary>method that returns True if the object is aninstance of
/// a class that inherits from the specified class, otherwise return False.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            if (derivedType != baseType)
            {
                return true;
            }
        }
        return false;
    }
}