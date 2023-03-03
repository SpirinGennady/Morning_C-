// HomeWork_1

// Task_2. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
//     Console.WriteLine($"the first number {num1} is greater than the second {num2}");
// else
//     Console.WriteLine($"the first number {num1} is less than the second {num2}");



// Task_4. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



// Console.Write("Input a first number: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int maxNum = num1;
// if(num2 > maxNum) maxNum = num2;
// if(num3 > maxNum) maxNum = num3;

// Console.WriteLine($"of the three given numbers {num1} {num2} {num3}, the largest is {maxNum}");





// Task_6. Напишите программу, которая на вход принимает число и выдаёт, 
//         является ли число чётным (делится ли оно на два без остатка).


// 4 -> да
// -3 -> нет
// 7 -> нет


// bool EvenNum(int num, int two)
// {
//     if(num % two == 0)
//         return true;
//     else
//         return false;
// }

//   Console.Write("Input a number: ");
//   int number = Convert.ToInt32(Console.ReadLine());
//   int two = 2;

//   bool result = EvenNum(number, two);
//   if(result)
//     Console.WriteLine($"{number} is an even number");
//     else
//     Console.WriteLine($"{number} is an odd number");



// Task_8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int two = 2;
// int current = 2;

// if(num % two == 0);
// while(current <= num)
// {
//     Console.Write(current + " ");
//     current = current+2;
// }