/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

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