// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

void Fill3DMatrix(int[,,] matrix)
{
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = matrix[i, j, k] + num;

                num = num + 1;
            }
        }
    }
}

void PrintIndex(int[,,] arr)
{
    int[,,] array3D = new int[2, 2, 2];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
Console.Write("Введите количество строк (rows). rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (columns). columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество глубины (depth). depth = ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[rows, columns, depth];
Fill3DMatrix(array3D);
PrintIndex(array3D);