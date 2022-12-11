/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (number > 0)
{
    summ = summ + number % 10; // вычисляет последнюю цифру числа (365 % 10 = 5)
    number = number / 10; // number =/ 10; отбрасывает у числа последнюю цифру (365 / 10 = 36)
} 
Console.WriteLine($"Сумма цифр в числе равна {summ}"); 