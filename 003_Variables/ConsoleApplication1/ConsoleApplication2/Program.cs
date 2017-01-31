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

            //Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Создайте константу с именем -pi(число π «пи»), создайте переменную радиус с именем – r.Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран. 

            double pi = 3.14;
            int r = 22;

            float result = (float) pi * ( r * r);
            Console.WriteLine( result );
            Console.ReadKey();

        }
    }
}
