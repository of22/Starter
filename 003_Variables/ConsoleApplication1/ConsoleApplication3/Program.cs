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
            //Задание 4
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Напишите программу расчета объема -V и площади поверхности - S цилиндра.
            //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR 2 h
            //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR 2 + 2πR 2 = 2πR(R + h)
            //Результаты расчетов выведите на экран.

            double pi = 3.14;
            int r = 22;
            int h = 30;
            float V;
            float result = (float)pi * (r * r);

            V = (float) pi * (r * r) * h;
            Console.WriteLine(V);


            float S = (float) ( 2*( pi*( r*r))) * (r + h);
            Console.WriteLine(S);
            Console.ReadKey();


        }
    }
}
