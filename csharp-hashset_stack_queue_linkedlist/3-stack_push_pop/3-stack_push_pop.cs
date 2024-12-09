using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int Nitems = aStack.Count;
        Console.WriteLine("Number of items: {0}", Nitems);
        if (Nitems <= 0)
            Console.WriteLine("Stack is empty");
        else  
            Console.WriteLine("Top item: {0}", aStack.Peek());
        
        if (!aStack.Contains(search))
            Console.WriteLine("Stack contains \"{0}\": False", search);
        else
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aStack.Contains(search))
                aStack.Pop();
        }
        aStack.Push(newItem);
        return (aStack);
    }
}
