/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

for (int j = 0; j < array.GetLength(1); j++)
{
    double result = 0;
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = result + array[i, j];
        average = result / array.GetLength(0);
    }
    Console.Write($"{String.Format("{0:0.00}", average)} ");  //($"{result / array.GetLength(0)} ");
}