using System;

/// <sumary> contains multiple method for objects </sumary>
class Obj
{
    /// <sumary> check if an object <paramref name="derivedType"/> is a subclass of <paramref name="baseType"/></sumary>
    /// <return> true if <paramref name="derivedType"/> is a subclass of <paramref name="baseType"/></return>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
