// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[m, n];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = new int[m, n];
FillArray(array2);
PrintArray(array2);

int[,] array3 = new int[m, n];

void MultiplicationMatrix(int[,] array)
{
    int x = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int b = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int y = 0;
            for(int a = 0; a < array2.GetLength(1); a++)
            {
                array[i, j] += array1[x,y] * array2[a,b];
                y++;
            }
            Console.Write(array[i,j] + " ");
            b++;
        }
        Console.WriteLine();
        x++;
    }
}

Console.WriteLine("Произведение двух матриц:");
MultiplicationMatrix(array3);