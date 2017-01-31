using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Напишите программу -консольный калькулятор.
            //Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые произвольные значения.
            //Предложите пользователю ввести знак арифметической операции. Примите значение введенное пользователем и поместите его в строковую переменную sign.
            //Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.Выведите на экран результат выполнения арифметической операции.  
            //В случае использования операции деления, организуйте проверку попытки деления на ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.

            int first = 12;
            double second = 23.3;
            char operation;

            operation = Console.ReadKey().KeyChar;

            Console.WriteLine();

            switch (operation)
            {
                case '*':
                    Console.WriteLine(first * second);
                    break;
                case '/':
                    if (first.Equals(0) | second.Equals(0))
                    {
                        Console.WriteLine("Zero detected");
                        break;
                    }
                    Console.WriteLine(first / second);
                    break;
                case '-':
                    Console.WriteLine(first - second);
                    break;
                case '+':
                    Console.WriteLine(first + second);
                    break;
            }

            Console.ReadKey();

        }
    }
}
