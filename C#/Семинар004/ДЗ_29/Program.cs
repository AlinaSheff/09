// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void Array(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    { 
        array[i] = new Random().Next(1, 100); 
        if(i < size - 1)
        {
           Console.Write($"{array[i]}, "); 
        }
        else
        { 
           Console.Write($"{array[i]}"); 
        }
    }
}

Array(8);

