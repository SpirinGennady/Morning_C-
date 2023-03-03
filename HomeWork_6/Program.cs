// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int InputPositiveNum(int m)
// {
//     int courent = 0;
//     for(int i = 0; i < m; i++)
//     {
//         Console.Write("Input a number: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if (number > 0) courent++;
//     }
//     return courent;
// }
// Console.Write("How many numbers do you want to check?: ");
// int m = Convert.ToInt32(Console.ReadLine());
// while(m < 0)
// {
//     Console.Write($"Error: {m} is not a positive number. Try again: ");
//     m = Convert.ToInt32(Console.ReadLine());
// }
// int courent = InputPositiveNum(m);
// Console.WriteLine($"There are positive numbers in your input: {courent} ");



// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void CrossPoint(double b1, double k1, double b2, double k2)
// {
//     if (b1 != b2 && k1 == k2)
//         Console.WriteLine($"Lines with coordinates: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} are parallel. There are no cross points of them.");
//     else
//     {
//         if (b1 == b2 && k1 == k2) Console.WriteLine($"Lines with coordinates: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} are one line.");
//         else
//         {

//             double x = (b2 - b1) / (k1 - k2);
//             double y = (k1 * x) + b1;
//             Console.WriteLine($"Lines with coordinates: b1 = {b1}, k1 = {k1} and b2 = {b2}, k2 = {k2} are crossing in coordinates x = {x}, y = {y}");
//         }
//     }
// }

// Console.Write($"Input a point b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Input a point k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Input a point b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Input a point k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// CrossPoint(b1, k1, b2, k2);

