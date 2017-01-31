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


            //Задание 1 
            //Выучите основные акронимы и понятия, рассмотренные на уроке.
            //Выучите все типы данных, рассмотренные на уроке и диапазоны значений типов: byte, sbyte, short, ushort, int, uint, long, ulong.
            //Запомните значения по умолчанию для всех простых типов данных. 


            //Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Дано значение числа pi, которое равно 3,141592653 и значение числа Эйлера е, 
            //которое равно 2,7182818284 590452.Создайте две переменные, присвойте им значения числа 
            //pi и числа е и выведите их на экран без потери точности.

            decimal a =  3.141592653M;
            decimal b = 2.7182818284590452M;


            Console.WriteLine(a);
            Console.WriteLine(b);

            //Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Создайте три строковые переменные и присвойте им значения: 
            //"\nмоя строка 1"
            //"\tмоя строка 2"
            //"\aмоя строка 3"
            //Выведите значение каждой переменной на экран. Какие отличия вы увидели. Сделайте выводы. 

            Console.WriteLine("\nмоя строка 1");
            Console.WriteLine("\tмоя строка 2");
            Console.WriteLine("\aмоя строка 3");

            Console.ReadKey();

        }
    }
}
