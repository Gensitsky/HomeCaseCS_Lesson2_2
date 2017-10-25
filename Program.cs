/*Преобразовать массив так, чтобы сначала шли все
отрицательные элементы, а потом положительные
(0 считать положительным)*/
using System;

namespace HomeCaseCS_Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = 10;
            int[] arr = new int[length];
            Console.WriteLine("Source array:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                Console.Write(arr[i] + " | ");
            }
            Console.WriteLine("\n\nSorted array:");
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " | ");
            }
            Console.ReadKey();
        }
    }
}