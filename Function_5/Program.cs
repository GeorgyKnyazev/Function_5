using System;
using System.Collections.Generic;
using System.Text;

namespace Function_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,10};
            ShuffleArray(array);

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
            Console.ReadKey();
        }
        static void ShuffleArray(int[] array)
        {
            Random rand = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                Swap(array, i, i + rand.Next(array.Length - i));
            }
        }
        static void Swap (int[] array, int i, int random)
        {
            int tempNumber = array[i];
            array[i] = array[random];
            array[random] = tempNumber;
        }
    }
}
