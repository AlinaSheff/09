// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m1, n1];
FillArray(array1);
PrintArray(array1);

Console.Write("Введите количество строк 2 массива: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[m2, n2];
FillArray(array2);
PrintArray(array2);

void MultiplicationMatrix(int[,] array)
{
    if (array1.GetLength(1) != array2.GetLength(0)) Console.WriteLine("Такие матрицы умножать нельзя!");
    else
    {
        Console.WriteLine("Произведение двух матриц:");
        
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                for(int k = 0; k < array1.GetLength(1); k++)
                {
                    array[i, j] += array1[i,k] * array2[k,j];
                }
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}

int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
MultiplicationMatrix(array3);
