﻿Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine($"max = {numA}, min = {numB}");
}
else
{
    Console.WriteLine($"max = {numB}, min = {numA}");
}
