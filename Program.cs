﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
Console.Write("Введите число A: ");
int numbA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numbB = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < numbB; i++)
{
    result *= numbA;
}
Console.WriteLine($"Число {numbA} в {numbB} степени равно {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (numb > 0)
{
    result += numb % 10;
    numb = numb / 10;
}
Console.WriteLine($"Сумма всех цифр равна {result} ");
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int size = 8;
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(100);
    }
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
