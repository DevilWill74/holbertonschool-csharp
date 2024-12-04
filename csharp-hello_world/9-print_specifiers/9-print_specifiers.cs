using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;

        // Formattage du pourcentage
        Console.WriteLine($"Percent: {percent.ToString("P2", CultureInfo.InvariantCulture)}");

        // Formattage de la monnaie
        Console.WriteLine($"Currency: {currency.ToString("C2", CultureInfo.GetCultureInfo("en-US"))}");
    }
}