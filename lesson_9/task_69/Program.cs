/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит 
число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.WriteLine("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int  numB = Convert.ToInt32(Console.ReadLine());

int Pow(int numA, int numB) 
{
    if (numB == 1)
        return numA;
    return numA * Pow(numA, --numB);
}

Console.WriteLine(Pow(numA, numB));