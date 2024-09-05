using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomConverter converter = new CustomConverter();

            
            Console.WriteLine("Введите число для конвертации в int:");
            string inputInt = Console.ReadLine();
            converter.Convert(inputInt, out int convertedInt);
            Console.WriteLine($"Результат конвертации в int: {convertedInt}");

            
            Console.WriteLine("Введите число для конвертации в double:");
            string inputDouble = Console.ReadLine();
            converter.Convert(inputDouble, out double convertedDouble);
            Console.WriteLine($"Результат конвертации в double: {convertedDouble}");
        }
    }
}