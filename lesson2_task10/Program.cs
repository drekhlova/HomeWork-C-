/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 

Console.WriteLine("Введите трёхзначное число: ");
string number = Console.ReadLine();
Console.WriteLine($"{number[1]}"); 
*/

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    string str = number.ToString();
    Console.WriteLine($"{str[1]}"); 
}
else Console.WriteLine("Число не трехзначное");