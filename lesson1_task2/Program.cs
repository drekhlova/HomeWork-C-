/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число 1: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB) 
{
    Console.WriteLine("Число 1 больше числа 2");
    Console.WriteLine($"max = {numA}");
    Console.Write($"min = {numB}");
}
else if (numA < numB)
{
    Console.WriteLine("Число 1 меньше числа 2");
    Console.WriteLine($"max = {numB}");
    Console.Write($"min = {numA}");
}
else
{
    Console.WriteLine("Число 1 равно числу 2. Невозможно определить max и min");
} 