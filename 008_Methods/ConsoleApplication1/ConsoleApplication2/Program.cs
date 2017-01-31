
using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3
            //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            //Напишите программу, которая будет выполнять конвертирование валют.  
            //Пользователь вводит: 
            //сумму денег в определенной валюте.
            //курс для конвертации в другую валюту. 
            //Организуйте вывод результата операции конвертирования валюты на экран. 

            Console.WriteLine("Enter your amount of money to convert, use comma as separator for decimal values");
            decimal value = Convert.ToDecimal( Console.ReadLine() );

            Console.WriteLine("Enter exchange rate");
            decimal exchangeRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Your converted amount is { value * exchangeRate }");
            Console.ReadKey();

        }
    }
}
