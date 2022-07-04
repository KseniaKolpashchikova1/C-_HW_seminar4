/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine($"Введите количество элементов массива:\t ");
        int elementsCount = int.Parse(Console.ReadLine());

        int[] myArray = new int[elementsCount];

        for (int i = 0; i < myArray.Length; i++)
        {
            Write($"\nВведите элемент массива под индексом {i}:\t ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Write($"\nВывод массива:\t ");

        for (int i = 0; i < myArray.Length - (myArray.Length-1); i++)
        {
            Write($"[{String.Join(",", myArray)}]");
        }

    }
}
