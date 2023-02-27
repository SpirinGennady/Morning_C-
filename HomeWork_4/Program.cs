// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



// void Construction(int a, int b)
// {
//     int result = 1;
//     if (b <= 0)
//     {
//         Console.WriteLine("Error: The degree entered is not natural!");
//     }
//     else
//     {
//         for (int i = 1; i <= b; i++)
//             result = result * a;
//         Console.WriteLine($"The number {a} to the degree of {b} is {result}");
//     }
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the natural degree: ");
// int pow = Convert.ToInt32(Console.ReadLine());
// Construction(num, pow);




// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SumUnit(int num)
// {
//     int sum = 0;
//    while (num > 0)
// {
//     int digit = num % 10;
//     num = num / 10;
//     sum = sum + digit;
// }
//     return sum;
// }

// Console.Write(" Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = SumUnit(number);
// Console.WriteLine($"accepts a number {number} as input and outputs the sum of digits {result}");



// Задача 29: 
// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input the value in the cell {i + 1}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("[ ");
//         Console.Write(array[i]);
//         if (i >= 0 && i != array.Length - 1) Console.Write(", ");
//         else Console.Write(" ]");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the size of the array: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(sizeArray);
// ShowArray(array);


