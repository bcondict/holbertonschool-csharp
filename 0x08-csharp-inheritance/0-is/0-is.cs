using System;

/// <sumary> contains multiple method for objects </sumary>
class Obj
{
    /// <sumary> check if an object is an int or no </sumary>
    /// <return> true if <paramref name="obj"/> is int </return>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}
