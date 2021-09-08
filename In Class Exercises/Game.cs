using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Exercises
{
    class Game
    {
        public void Run()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5 };
            PrintNumbers(testArray, 5);
        }

        void PrintNumbers(int[] numbers, int size)
        {

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }

        void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
