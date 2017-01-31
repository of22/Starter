namespace ConsoleApplication3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            //Напишите метод, который будет определять:  
            //1) является ли введенное число положительным или отрицательным.

            //2) Является ли оно простым (используйте технику перебора значений).  
            //(Простое число — это натуральное число, которое делится на 1 и само на себя. Чтобы определить простое число или нет, 
            //следует найти все его целые делители.Если делителей больше 2 - х, значит оно не простое.) 

            //3) Делится ли на 2, 5, 3, 6, 9 без остатка. 

            long value = Convert.ToInt64(Console.ReadLine());

            DefineNumberParameters(value);

        }

        private static void DefineNumberParameters(long value)
        {
            //1
            Console.WriteLine("Is value bigger than zero? " + BiggerOrSmalerThanZero(value));

            //2

            Console.WriteLine("Is value prime? " +  IsPrimeNumber(value) );

            //3
            Console.WriteLine($"Can be divided on  next numbers without remainder? \n 2 - {Div(value, 2)}, \n 5 - {Div(value, 5)}, \n 3 - {Div(value, 3)}, \n 6 - {Div(value, 6)}, \n 9 - {Div(value, 9)} ");

            Console.ReadLine();
        }

        /// <summary>
        /// Enter your number to define if it 
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <param name="divider"></param>
        /// <returns></returns>
        private static bool Div( long valueToCheck, int divider)
        {
            if (valueToCheck%divider == 0)
            {
                return true;
            }
            return false;
        }



        private static bool IsPrimeNumber(long value)
        {
            if (value > 1)
            {
                int dividers = 0;

                for (int a = 2; a < value; a++ )
                {
                    if ( value % a == 0 )
                    {
                        dividers++;
                    }
                }
                if (dividers == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static string BiggerOrSmalerThanZero(long value)
        {
            return value > 0 ? "Bigger" : value < 0 ? "Smaller" : value == 0 ? "Equals zero" : "Infinite number";
        }

    }
}
