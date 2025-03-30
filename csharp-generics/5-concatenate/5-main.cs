class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        System.Console.WriteLine(myStrQ.Concatenate());

        System.Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Concatenate();

        System.Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        myCharQ.Enqueue('a');
        myCharQ.Enqueue('b');
        myCharQ.Enqueue('c');
        System.Console.WriteLine(myCharQ.Concatenate());
    }
}