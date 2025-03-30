using System;

/// <summary> Queue Class </summary>
/// <typeparam name="T"> Template/Type of elements </typeparam>
class Queue<T>
{
    /// <summary> returns the Queue’s type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}