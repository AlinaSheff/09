// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Stepen(int A, int B)
{
  int res = 1;  
    for(int count = 0;  count < B; count++)
    {
        res = res * A;
    }
    return res;
}

int res = Stepen(2, 4);
Console.WriteLine(res);