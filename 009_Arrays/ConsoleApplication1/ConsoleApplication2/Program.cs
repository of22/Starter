using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3
            //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            //Требуется:  
            //1) Создать метод MyReverse(int[] array), который принимает в качестве аргумента массив целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном порядке).  
            //2) Создайте метод int[] SubArray(int[] array, int index, int count).Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index, размерностью,
            // которая соответствует значению аргумента count.

            //Если аргумент count содержит значение больше чем количество элементов, которые входят в выбираемую часть исходного массива(от указанного индекса index, до индекса последнего элемента), 
            //то  при формировании нового массива размерностью в count, заполните единицами те элементы, которые не были скопированы из исходного массива.


            //1
            int[] array = {1, 2, 3, 4, 5, 6, 7};
            int[] reversedArray = MyReverse(array);


            foreach (var val in reversedArray)
            {
                Console.WriteLine( val );
            }

            Console.WriteLine("###################");

            //2
            int[] subArray = SubArray(array, 3, 10);
            foreach (var val in subArray)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }

        static int[] MyReverse(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int reversedArrayCounter = 0; 
            for (int counter = array.Length -1; counter >= 0; counter--)
            {
                reversedArray[reversedArrayCounter] = array[counter];
                reversedArrayCounter++;
            }

            return reversedArray;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int arrayIndex = index;
            int[] subarray = new int[count];
            
            //in for loop counter is used to iterate over new subarray
            for (int counter = 0; counter <= subarray.Length - 1; counter++)
            {
                //checking if such index exists in received array. When it
                if (arrayIndex <= array.Length - 1)
                {
                    subarray[counter] = array[arrayIndex]; 
                }
                else
                {
                    subarray[counter] = 1;
                }
                arrayIndex++;
            }

            return subarray;
        }


    }
}
