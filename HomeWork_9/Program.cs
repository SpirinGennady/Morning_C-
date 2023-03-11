// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturalNumbers(int n)
// {
//     Console.Write(n + " ");
//     if ( n > 1) NaturalNumbers(n - 1);
//     Console.Write(n + " ");
// }
// Console.Write("Input a natural number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(num);



// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElemets(int m, int n)
{
    if ( m > n)
    {
        for (int current = m; current < n; current ++)
        sum += current;
    return sum;
    }
    return SumElemets;
}

Console.Write("Input a first number: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numN = Convert.ToInt32(Console.ReadLine());

SumElemets(numM, numN);



// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


