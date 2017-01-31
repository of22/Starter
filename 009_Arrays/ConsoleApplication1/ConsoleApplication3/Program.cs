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
            //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            //Требуется:  
            //Создать метод, который будет выполнять увеличение длины массива переданного в качестве аргумента, на 1 элемент.Элементы массива, должны сохранить свое значение и порядок индексов. 
            //Создайте метод, который принимает два аргумента, первый аргумент -типа int[] array, второй аргумент - типа int value. В теле метода реализуйте возможность добавления второго аргумента 
            //метода в массив по индексу – 0, при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого массива в качестве первого аргумента должны скопироваться в
            //новый массив начиная с индекса -1.

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            int[] newArray = IncreaseArrayByOne(array);

            foreach (var val in newArray)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }

        private static int[] IncreaseArrayByOne( int[] array)
        {
            int[] newArray = new int[array.Length + 1];

            for (int counter = 0; counter<=array.Length-1; counter++)
            {
                newArray[counter] = array[counter];
            }
            return newArray;
        }

    }
}
