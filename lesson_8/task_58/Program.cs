/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
a1 2 b1 4 | c1 3 d1 4  |  a1c1 + b1c2    a1d1 + b1d2   
a2 3 b2 2 | c2 3 d2 3  |  a2c1 + b2c2    a2d1 + b2d2
Результирующая матрица будет:
18 20
15 18
*/

int[,] arr1 = new int[2, 2] {
            {2, 4},
            {3, 2}
            };

int[,] arr2 = new int[2, 2] {
            {3, 4},
            {3, 3}
            };

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


int [,] MultiArray(int[,] arr1, int[,] arr2)
    {
      int[,] multiArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
      for (int i = 0; i < arr1.GetLength(0); i++)
      {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
          for (int k = 0; k < arr1.GetLength(1); k++)
          {
            multiArr[i, j] += arr1[i, k] * arr2[k, j];
          }
        }
      }
      return multiArr;
    }

PrintArray(arr1);
PrintArray(arr2); 
PrintArray(MultiArray(arr1, arr2));