// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.Write("Введите количество строк (rows). rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк (columns). columns = ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(rows, columns, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = FillMatrix(rows, columns, -9, 9);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];
MultiplyMatrix(matrix, matrix2, matrix3);
PrintMatrix(matrix3);