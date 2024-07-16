// See https://aka.ms/new-console-template for more information
using DiamondKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a UPPERCASE letter:");

        Console.WriteLine(Diamond.Create(Char.Parse(Console.ReadLine())));
    }
}


