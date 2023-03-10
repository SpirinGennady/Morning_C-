

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNums(int num) 
// {
//     if (num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
// }

// ShowNums(10);


//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num) 
// {
//     if (num / 10 != 0)
//         return SumOfDigits(num / 10) + Math.Abs(num % 10);
//     return Math.Abs(num);
// }

// Console.WriteLine(SumOfDigits(-1234));



//Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.

// void ShowNums(int m, int n) 
// {
//     Console.Write(m + " ");

//     if (m > n) 
//         ShowNums(m - 1, n);
//     else if (m < n)
//         ShowNums(m + 1, n);    
// }

// ShowNums(8, 2);
// Console.WriteLine();
// ShowNums(2, 8);



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