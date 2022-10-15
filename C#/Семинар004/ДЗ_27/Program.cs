// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int Sum(int x)
{
   int sum = 0;
   int y = 0;
    for(int i = x; i > 0; i = x /= 10)
    {
       y = x % 10;
       sum = sum + y;
    }
    return sum;
}

int sum = Sum(9012);
Console.WriteLine(sum);
