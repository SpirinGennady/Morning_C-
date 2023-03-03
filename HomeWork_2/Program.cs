
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int CenterNumber( int num)
// {
//     int tens = num / 10;
//     int units = tens % 10;
//     int result = units;

//     return result; 
// }

//  Console.Write("Input three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int newNumber = CenterNumber(number);
//  Console.WriteLine( $"New version of {number} is {newNumber}");

// 753



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



// Console.Write("Input a number: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// while (number > 999)
// {
//     int result = number / 10;
//     number = result; 

//   }

// if (number < 1000 && number >=100)
// {int thirdDigit = number % 10;
// Console.WriteLine($"Third digit is {thirdDigit}");
// }

// else if (number < 100)
// {Console.WriteLine("there is no third digit!");}






// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// int week1 = 6;
// int week2 = 7;
// bool Weekends( int num )
// {
//     if(num  == week1 || num == week2)
//         return true;  
//     else
//         return false;
// }
 
//  Console.Write("Input number of the week: ");
//  int number = Convert.ToInt32(Console.ReadLine());

// bool result = Weekends(number);

// if(result)
//     Console.WriteLine($"{number} - this number of the week is a weekend ");
// else
//    Console.WriteLine($"{number} - this number of the week is not a weekend "); 


