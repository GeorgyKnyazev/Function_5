using System;

namespace Function_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nambers = { 1,2,3,4,5,6,7,8,9,10};

            WriteArray(nambers);

            Console.WriteLine();

            ShuffleArray(nambers);
            
            WriteArray(nambers);

            Console.ReadLine();
        }

        static void ShuffleArray(int[] array)
        {
            Random random = new Random();
            int tempNumber;
            int randomNumber;
            
            for (int i = 0; i < array.Length; i++)
            {
                randomNumber = random.Next(array.Length - i);
                tempNumber = array[i];
                array[i] = array[randomNumber];
                array[randomNumber] = tempNumber;

            }
        }
        static void WriteArray(int[] array)
        {
            for (int h = 0; h < array.Length; h++)
            {
                Console.Write(array[h]);
            }
        }
    }
}
