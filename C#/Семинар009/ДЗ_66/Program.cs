// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
int temp = M;

 if (M > N)
 {
     M = N;
     N = temp;
 }

void Sum(int M, int N)
{
    result = result + M;
    if(M == N)
    {
        Console.Write(result);
        return;
    }
    Sum(M+1, N);
}    
Sum(M, N);
