using System;

/// <summary> Custom Generic Queue class </summary>
/// <typeparam name="T"> Generic type </typeparam>
class Queue<T>
{
    /// <summary>
    /// Check the type of the Queue
    /// </summary>
    /// <returns>Return the Queue's type</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
