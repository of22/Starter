using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток
            //[0 - 14][15 - 35][36 - 50][50 - 100].Если да, то укажите, в какой именно промежуток.Если пользователь указывает число не
            // входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение. 



            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (number >= 0 & number <= 14 )
            {
                Console.WriteLine(" [0 - 14] range");
            }
            else if (number >= 15 & number <= 35)
            {
                Console.WriteLine(" [15 - 35] range");
            }
            else if (number >= 36 & number <= 50)
            {
                Console.WriteLine(" [36 - 50] range");
            }
            else if (number >= 50 & number <= 100)
            {
                Console.WriteLine(" [50 - 100] range");
            }
            else
            {
                Console.WriteLine("doesnt fit to any range");
            }

            Console.ReadKey();


        }
    }
}
