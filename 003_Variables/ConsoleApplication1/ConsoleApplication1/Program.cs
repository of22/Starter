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
            // Имеется 3 переменные типа int x = 10, y = 12, и z = 3;
            //Выполните и рассчитайте результат следующих операций для этих переменных:
            // 
            //	x += y - x++ * z; 
            //	z = --x – y * 5; 
            //	y /= x + 5 % z; 
            //	z = x++ + y * 5; 
            //	x = y - x++ * z;
            //

            int x = 10, y = 12, z = 3;
            Console.WriteLine(@"x = {0}, y = {1}, z = {2}", x, y, z);

            x += y - x++ * z;
            Console.WriteLine(@"x = {0}, y = {1}, z = {2}", x, y, z);
            
            z = --x - y * 5;
            Console.WriteLine(@"x = {0}, y = {1}, z = {2}", x, y, z);

            y /= x + 5 % z;
            Console.WriteLine(@"x = {0}, y = {1}, z = {2}", x, y, z);

            z = x++ + y * 5;
            Console.WriteLine(@"x = {0}, y = {1}, z = {2}", x, y, z);

            x = y - x++ * z;
            Console.WriteLine(@"x = {0}, y = {1}, z = {2}", x, y, z);

            Console.ReadKey();
            //Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
            //С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного отображения результата? 


            int x1 = 11, y1 = 11, z1 = 11;

            Console.WriteLine( ( x1 + y1 + z1)/3 );

            Console.ReadKey();



            //Задание 6
            //Зайдите на сайт MSDN. 
            //Используя поисковые механизмы MSDN, найдите самостоятельно описание темы по каждому примеру, который был рассмотрен на уроке, 
            //так, как это представлено ниже, в разделе «Рекомендуемые ресурсы», описания данного урока. Сохраните ссылки и дайте им короткое описание.

        }
    }
}
