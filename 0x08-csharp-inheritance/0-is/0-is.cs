using System;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj in int)
            return true;
        return false;
    }
}
