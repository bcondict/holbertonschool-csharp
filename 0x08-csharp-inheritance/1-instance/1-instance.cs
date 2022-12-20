using System;
using System.Collections.Generic;

/// <sumary> contains multiple method for objects </sumary>
class Obj
{
    /// <sumary> check if an object is an array instace or no </sumary>
    /// <return> true if <paramref name="obj"/> is an array instance</return>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}
