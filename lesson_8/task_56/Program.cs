/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/


void PrintArray(int[,] array)
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

int[,] arr = new int[4, 4] {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
            };

Console.WriteLine();
PrintArray(arr);

int minSummRow = 0;
int summRow = SummRowElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSummRow = SummRowElements(arr, i);
  if (summRow > tempSummRow)
  {
    summRow = tempSummRow;
    minSummRow = i;
  }
}

Console.WriteLine($"Строка с наименьшей суммой элементов - {minSummRow+1}.");

int SummRowElements(int[,] arr, int i)
{
  int summRow = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    summRow = summRow + arr[i,j];
  }
  return summRow;
}