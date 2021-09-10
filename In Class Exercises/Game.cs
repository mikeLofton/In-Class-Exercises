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

            int[] minMaxArray = new int[] { 1, 2, 3 };
            PrintMaxAndMin(minMaxArray);
        }

        //How I did it
        void PrintNumbers(int[] numbers, int size)
        {

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }

        //How Lodis did it
        void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //Max and Min Exercise
        void PrintMaxAndMin(int[] numbers)
        {
            int largest = numbers[0];
            int smallest = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }

                else if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine("Largest: " + largest);
            Console.WriteLine("Smallest " + smallest);
        }

        //For Each Example
        void ExamplePrint (int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    
    }
}
