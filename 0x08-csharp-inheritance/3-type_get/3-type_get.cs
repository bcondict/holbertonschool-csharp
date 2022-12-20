using System;

/// <sumary> Contains multiple methods for Obj</sumary>
class Obj
{
    /// <sumary> Print object info. </sumary>
    public static void Print(object myObj)
    {
        Console.WriteLine(myObj.GetType().Name + " Properties:");
        foreach (var property in myObj.GetType().GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine(myObj.GetType().Name + "Methods:");
        foreach (var method in myObj.GetType().GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
