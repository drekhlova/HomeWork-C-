﻿/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (N == 1)
{
    Console.Write("Нет четных чисел");
}

while (count <= N)
{
    Console.Write($"{count} ");
    count = count + 2;
}