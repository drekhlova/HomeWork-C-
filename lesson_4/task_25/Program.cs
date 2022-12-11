/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/*
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
{
    double result = 0;
    result = Math.Pow(A, B);
    Console.WriteLine(result);
}
*/

/*
Main(A, B);
void Main(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine($"Результат возведения числа {A} в степень {B} = {result}.");
}
*/

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= B; i++)
    {
    result = result * A;
    }
Console.WriteLine($"Результат возведения числа {A} в натуральную степень {B} = {result}.");