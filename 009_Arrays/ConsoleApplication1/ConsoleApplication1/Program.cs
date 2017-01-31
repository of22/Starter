using System;
using System.Linq.Expressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

//            Задание 2
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется:  
//Создать массив размера N элементов, заполнить его произвольными целыми значениями(размер массива задает пользователь).
//Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 

            int x = 0;


            Console.WriteLine("Write length of array");
            int amount = Convert.ToInt32(Console.ReadLine());

            int []arrayOne = new int[amount];
            int sumOfAllValues = 0;

            for (int counter = 0; counter <= arrayOne.Length-1; counter++)
            {
                arrayOne[counter] = x;
                sumOfAllValues += arrayOne[counter];
                x++;
            }

            int biggest = arrayOne[0];
            int smallest = arrayOne[0];

            foreach (var cell in arrayOne)
            {
                if (cell > biggest) { biggest = cell; }
                if (cell < smallest) { smallest = cell; }
            }

            Console.WriteLine("Sum of all values = " + sumOfAllValues);
            Console.WriteLine($"Biggest = {biggest} smallest = {smallest} ");
            Console.WriteLine("Sum of all values = " + sumOfAllValues);
            Console.WriteLine("Intermediate value = " + sumOfAllValues / arrayOne.Length );

            Console.WriteLine("Non even numbers in array: ");
            for (int counter = 0; counter <= arrayOne.Length - 1; counter++)
            {
                if (arrayOne[counter]%2 != 0)
                {
                    Console.WriteLine( arrayOne[counter] );
                }
            }
            Console.ReadLine();
        }
    }
}
