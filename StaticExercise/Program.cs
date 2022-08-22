using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Celsius to convert to Fahrenheit: ");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(num));

            Console.WriteLine();

            Console.WriteLine("Enter a Fahrenheit to convert to Celsius: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(TempConverter.FahrenheitToCelsius(num));
        }
    }
}