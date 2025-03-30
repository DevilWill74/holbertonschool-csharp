using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myQ = new Queue<string>();

        myQ.Enqueue("Hello");
        myQ.Enqueue("Holberton");
        myQ.Enqueue("School");

        myQ.Print();
    }
}