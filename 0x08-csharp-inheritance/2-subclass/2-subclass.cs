using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        // if (derivedType is baseType)
        // if (derivedType.GetType() is baseType.GetType())
        // if ((baseType is derivedType) != null)
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
