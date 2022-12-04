/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет 

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    string str = day.ToString();
    Console.WriteLine("Нет"); 
}
else if (day == 2)
{
    string str = day.ToString();
    Console.WriteLine("Нет"); 
}
else if (day == 3)
{
    string str = day.ToString();
    Console.WriteLine("Нет"); 
}
else if (day == 4)
{
    string str = day.ToString();
    Console.WriteLine("Нет"); 
}
else if (day == 5)
{
    string str = day.ToString();
    Console.WriteLine("Нет"); 
}
else if (day == 6)
{
    string str = day.ToString();
    Console.WriteLine("Да"); 
}
else if (day == 7)
{
    string str = day.ToString();
    Console.WriteLine("Да"); 
}
else
{
    string str = day.ToString();
    Console.WriteLine("В неделе 7 дней. Пожалуйста, введите число от 1 до 7");
}  
*/

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("В неделе 7 дней. Пожалуйста, введите номер от 1 до 7");
}
else if (day > 5)
{
    Console.WriteLine("Ура! Выходные!"); 
}
else Console.WriteLine("Трудовые будни");