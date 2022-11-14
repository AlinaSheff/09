// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            array[i, j, k] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})" + " ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine("Введите размер трехмерного массива через Enter: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, l];
FillArray(array);
NewArray(array);
PrintArray(array);

void NewArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                for(int a = 0; a < array.GetLength(0); a++)
                {
                    for(int b = 0; b < array.GetLength(1); b++)
                    {
                        for(int c = 0; c < array.GetLength(2); c++)
                        {
                            if (array[i, j, k] == array[a, b, c]) array[i, j, k] = new Random().Next(10, 100);
                        }
                    }
                }
            }
        }
    }
}


