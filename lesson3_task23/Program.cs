/* Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double GetQuarter(int number)
{
    double result = 0;
    result = (Math.Pow(number, 2));
    return result;
}
Console.WriteLine($"Квадрат числа {number} составит  {GetQuarter(number)}"); */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < number+1; i++)
{
    Console.WriteLine($"{i*i*i}");
}