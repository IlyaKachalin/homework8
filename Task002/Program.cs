// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] FillMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.Write("]");
        Console.WriteLine();
    }

}

void FindSum(int[,] matrix)
{
    int sum = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow = minRow + matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < minRow)
        {
            minRow = sum;
            minRow = i;
        }
        sum = 0;
    }
    Console.Write($"{sum + 1}");
}

Console.Write("Введите количество строк (rows). rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк (columns). columns = ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(rows, columns, -9, 9);
PrintMatrix(matrix);
FindSum(matrix);
