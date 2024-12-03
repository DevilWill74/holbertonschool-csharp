using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int n = number % 10;
        if (n < 0)
            n = n * (-1);
        Console.Write(n);
        return n;
    }
}