// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

Console.WriteLine("Упорядоченные по убыванию элементы каждой строки двумерного массива:");

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int k = array.GetLength(1) - 1; k > j; k--)
        {
            if(array[i,k-1] < array[i,k]) 
            {
                int temp = array[i,k];
                array[i,k] = array[i,k-1];
                array[i,k-1] = temp;
            }
            
        }
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}