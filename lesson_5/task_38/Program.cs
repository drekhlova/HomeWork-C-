/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array =  new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Задан массив: ");

    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }

int max = array[0];
int min = array[0];
int summ = 0;

for (int i = 0; i < array.Length; i++)
{
  if(array[i] > max) max = array[i];  
}
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min) 
    min = array[i];
}
summ = max - min;

Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива равен {max}. Минимальный элемент массива равен {min}. Разница между максимальным и минимальным элементами массива равна {summ}.");