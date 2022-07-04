/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
 */
using System;
using static System.Console;

Clear();

Write("Введите число: ");
int numberN = Convert.ToInt32(ReadLine());

int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");

int SumNumber(int s)
{
int count = Convert.ToString(numberN).Length;
int accumulate = 0;
int accumCompositon = 0;
    for (int i = 0; i < count; i++)
    {
      accumulate = numberN - numberN % 10;
      accumCompositon = accumCompositon + (numberN - accumulate);
      numberN = numberN / 10;
  
    }
   return accumCompositon;
  } 