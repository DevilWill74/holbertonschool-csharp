using System;

class Program
{
    static void Main(string[] args)
    {
        int r;

        // Appeler la méthode avec différentes valeurs et afficher le résultat
        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine(r); // Affiche également le retour de la méthode
    }
}