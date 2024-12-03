using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        // Calculer la dernière chiffre en prenant la valeur absolue et le modulo 10
        int lastDigit = Math.Abs(number % 10);
        
        // Afficher la dernière chiffre
        Console.Write(lastDigit);

        // Retourner la dernière chiffre
        return lastDigit;
    }
}