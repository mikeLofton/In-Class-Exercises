using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Exercises
{
    class Game
    {
        public void Run()
        {
            int[] numbers = new int[] { 1, 2, 3, 4 };

            numbers = AppendToArray(numbers, 5);

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

        int[] AppendToArray(int [] arr, int value)
        {
            //Create a new array with one more slot than the old array
            int[] tempArray = new int[arr.Length + 1];

            //Copy the values from the old array into a new array
            for (int i = 0; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }

            //Set the last index to be the new item
            tempArray[tempArray.Length - 1] = value;

            //Return the new array
            return tempArray;
        }

        private void ArrayPractice()
        {                                                    /*0  1  2*/
            int[,] array2DInitExample = new int[3, 3] { /*0*/{ 1, 2, 3 }, 
                                                        /*1*/{ 4, 5, 6 }, 
                                                        /*2*/{ 7, 8, 9 } };
            int[,] array2DInitExample2 = { { 1, 2, 3 },
                                           { 4, 5, 6 },
                                           { 7, 8, 9 },
                                           { 10, 11, 12} };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array2DInitExample[i, j]);
                }
            }

            void Add2DArrayValues(int[,] arr)
            {
                int sum;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sum += arr[i, j];

                    }
                    Console.WriteLine(sum);
                }
            }

            Add2DArrayValues(array2DInitExample);
        }
    }
}
