using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68); // 20
            var fahrenheit = TempConverter.CelciusToFahrenheit(20); //68

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
