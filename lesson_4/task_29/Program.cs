/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

//пользователь сам вводит кол-во элементов и указывает эти элементы

/*
Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array =  new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Вывод массива: ");

    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }

    */

int[] number =  new int[8];
Random random = new Random();

for (int i = 0; i < number.Length; i++)
{
    number[i] = random.Next(0, 100);
}
for (int i = 0; i < number.Length; i++)
{
    Console.Write(number[i] + " ");
}