

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNums(int num) 
// {
     // Console.Write(num + " "); // показывает на этапе погружения в терминале
//     if (num > 1) ShowNums(num - 1);
//     Console.Write(num + " "); // показывает на этапе возвращения в терминале
// }

// ShowNums(5);


//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num) // здесь переменную не создаём, чтобы не захламлять память
// {
//     if (num / 10 != 0)
//         return SumOfDigits(num / 10) + Math.Abs(num % 10);
//     return Math.Abs(num);
// }

// Console.WriteLine(SumOfDigits(1234));

// отработка рекурсии:
// f(1234) -> f(123) + 4
// f(123) -> f(12) + 3
// f(12) -> f(1) + 2
// f(1) -> 1
// f(12) -> 1 + 2 = 3
// f(123) -> 3 + 3 = 6
// f(1234) -> 6 + 4 = 10  это получили в терминале



//Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.

// void ShowNums(int m, int n) 
// {
//     if (m == n)
//         Console.Write(m + " ");
//     else 
//     {
//         if(m > n)
//         {
//              Console.Write(m + " ");
//              ShowNums(m - 1, n);
//         } 
//         else
//         {   
//             ShowNums(m, n - 1);
//             Console.Write(n + " ");   
//         }
//     }
// }

// ShowNums(5, 1);
// Console.WriteLine();
// ShowNums(1, 5);



//Напишите программу, которая на вход принимает два числа 
//A и B, и возводит число А в целую степень B.

// double Pow(double a, int b) {
//     if (b > 0)
//         return a * Pow(a, b - 1);
//     else if (b < 0)
//         return (1 / a) * Pow(a, b + 1);    
//     else 
//         return 1;
// }

// Console.WriteLine(Pow(3, 4));
// Console.WriteLine(Pow(3, -2));
// Console.WriteLine(Pow(2, -3));

// double Pow(double a, int b) // второй вариант
// {
//     if (b > 0)
//         return Pow(a, b - 1) * a;
//     else if (b < 0)
//         return Pow(a, b + 1) / a;    
//     else 
//         return 1;
// }

// Console.WriteLine(Pow(3, 4));
// Console.WriteLine(Pow(3, -2));
// Console.WriteLine(Pow(2, -3));