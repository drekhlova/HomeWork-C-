/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет  */


int[,] array = new int[3, 4] {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
                }; 

PrintMatrix(array);

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позицию элемента в строке: ");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите позицию элемента в столбце: ");
int columns = Convert.ToInt32(Console.ReadLine()) - 1;

if(rows < 0 || rows > array.GetLength(0) - 1 || columns < 0 || columns > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
else
    {
        Console.WriteLine($"Значение элемента массива = {array[rows, columns]}");
    }       