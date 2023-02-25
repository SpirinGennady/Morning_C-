// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Extent(int a, int b)
// {
//     int current = 0;
//     for()
// }


// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumUnit(int num)
{
    int sum = 0;
    // if( num == o) sum = 1;
    while(num != 0)
    {
        num /= 10;
        sum++; 
    }
    return sum;
}

Console.Write(" Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumUnit(number);
Console.WriteLine($"accepts a number {number} as input and outputs the sum of digits {result}");



// Задача 29: 
// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
