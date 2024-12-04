using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        Console.WriteLine("Percent: {0}", percent.ToString("P2", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Currency: {0}", currency.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
    }
}