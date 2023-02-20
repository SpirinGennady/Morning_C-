// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да




// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 8.66
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
// {
//     double hipotenuse = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
//     return hipotenuse;
// }

// Console.Write("Input first meaning x: ");
// int pointXA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input first meaning y: ");
// int pointYA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input first meaning z: ");
// int pointZA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second meaning x: ");
// int pointXB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second meaning y: ");
// int pointYB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second meaning z: ");
// int pointZB = Convert.ToInt32(Console.ReadLine());

// double length = Distance(pointXA, pointYA, pointZA, pointXB, pointYB, pointYB);

// Console.WriteLine($"distance from point {pointXA}:{pointYA}:{pointZA} to point {pointXB}:{pointYB}:{pointZB} is {length} ");






// Задача 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void TablePrint(int num)
// {
//     int current = 1;
//     while(current <= num)
//     {
//         Console.WriteLine(current + " " + Math.Pow(current, 3));
//         current++;
//     }

// }
// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// TablePrint(number);