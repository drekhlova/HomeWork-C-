/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9  */

Console.WriteLine("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
FillMatrix(numbers);
PrintMatrix(numbers);

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; 
            //double r = Convert.ToDouble(x.Next(-100, 100)/10.0); !!!
            //в данном случае мы имеем числа от -10 до 9.9

            //double r = Convert.ToDouble(x.Next(100)/10.0);
            // В данном случае мы имеем генерацию от 0 до 9.9
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}