using System;

namespace ConsoleApplication1
{
    class Program
    { 
        //            Задание 2
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub – вычитание, Mul – умножение, Div – деление.Каждый метод 
        //должен принимать два целочисленных аргумента и выводить на экран результат выполнения арифметической операции соответствующей имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль.
        //Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак арифметической операции, для выполнения вычислений.


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = ReadNumberFromConsole();

            Console.WriteLine("Enter operation");
            string operation = ReadOperationFromConsole();

            Console.WriteLine("Enter second number");
            int y = ReadNumberFromConsole();

            ExecuteOperation(x, y, operation);
            Console.ReadLine();
        }

        private static void ExecuteOperation(int x, int y, string operation)
        {
            switch (operation)
            {
                case "+":
                    Add(x,y);
                    break;
                case"-":
                    Sub(x,y);
                    break;
                case"*":
                    Mul(x, y);
                    break;
                case"/":
                    Div(x,y);
                    break;
            }
        }

        private static int ReadNumberFromConsole()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static string ReadOperationFromConsole()
        {
            return Console.ReadLine();
        }

        private static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        private static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void Mul(int a, int b)
        {
            Console.WriteLine( a * b);
        }

        private static void Div(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                Console.WriteLine(a / b);
            }
            Console.WriteLine("Division by zero insn't allowed");
        }
    }
        
}




