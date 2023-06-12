/*
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


Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (numb > 0)
{
    result += numb % 10;
    numb = numb / 10;
}
Console.WriteLine($"Сумма всех цифр равна {result} ");
