using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Дано два числа A и B (A < B) выведите суму всех чисел расположенных между данными числами на экран.
            //Дано два числа A и B(A < B) выведите все нечетные значения, расположенные между данными числами.

            int a = 22;
            int b = 33;
            int sum = 0;
            for (int c = a + 1; c < b; c++)
            {
                sum += c;
            }
            Console.WriteLine(sum);
            Console.WriteLine("************************\n");


            //Задание 3
            //Используя Visual Studio 2010, создайте проект по шаблону Console Application.
            //Используя циклы и метод:
            //Console.Write("*"), Console.Write(" "), Console.Write("\n")(для перехода на новую строку).
            //Выведите на экран:
            //· прямоугольник 
            //· прямоугольный треугольник  
            //· равносторонний треугольник   
            //· ромб

            // ****************************************************
            Console.WriteLine("########################");
            Console.WriteLine("\n ********** TASK 3 ****** \n");
            uint temp = 0;
            uint temp2 = 0;
            do
            {
                while (temp2 < 5)
                {
                    Console.Write("*");
                    ++temp2;
                }
                Console.Write("\n");
                temp2 = 0;
                ++temp;
            } while (temp < 5);
            Console.WriteLine("\n s######################## \n");
            // ****************************************************
            uint ts = 0;
            uint ts2 = 0;
            do
            {
                while (ts2 <= ts)
                {
                    Console.Write("*");
                    ++ts2;
                }
                Console.Write("\n");
                ts2 = 0;
                ++ts;
            } while (ts < 7);

            Console.WriteLine("\n s######################## \n");
            // ****************************************************
            byte  lines = 1;
            byte height = 9;
            do
            {
                for (uint starCounter = 0; starCounter < lines; ++starCounter)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                lines ++;
            } while (lines < height);

            do
            {
                for (uint starCounter = lines; starCounter > 0; --starCounter)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                lines--;
            } while (lines > 0);

            Console.WriteLine("\n ######################## \n");
            // ****************************************************

            byte rombLines = 1;
            const byte rombHeight = 7;
            byte spaces = 15;
            byte stars = 1;
            //building first half of romb
            do
            {
                for (byte spacesCounter = spaces; spacesCounter > 0; --spacesCounter)
                {
                    Console.Write(" ");
                }
                for (byte starCounter = 0; starCounter < stars; ++starCounter)
                {
                    Console.Write("*");
                }

                Console.Write("\n");

                spaces =  (byte) (spaces - 1);
                stars = (byte) (stars + 2);
                rombLines ++;
     
            } while (rombLines < rombHeight );
            //building second half of romb
            rombLines = 1;
            do
            {
                for (byte spacesCounter = 0; spacesCounter < spaces; ++spacesCounter)
                {
                    Console.Write(" ");
                }
                for (byte starCounter = 0; starCounter < stars; ++starCounter)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                spaces = (byte)(spaces + 1);
                stars = (byte)(stars - 2);
                rombLines++;

            } while (rombLines <= rombHeight);

            
            // exist other solutions - like field char length ~10 and we count amount of spaces and stars based on variable counter like 10 - 6 = 4 stars need to draw etc
            Console.WriteLine("\n ######################## \n");

            // ****************************************************


            //Задание 4
            //Имеется N клиентов, которым компания производитель должна доставить товар.Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина ?
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do -while.
            Console.WriteLine("\n ********** TASK 4 ****** \n");

            int counter = 1;
            int N = 5;
            int factorialValue = 1;

            do
            {
                factorialValue = factorialValue*counter;
                counter++;
                Console.WriteLine(factorialValue);
            } while (counter <= N);

            Console.WriteLine("Result is : {0}", factorialValue);

            Console.WriteLine("\n ######################## \n");
            Console.ReadKey();
            // 









        }
    }
}
