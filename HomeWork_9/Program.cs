// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturalNumbers(int n)  //первый способ, более энергоёмкий, но мне не особо понятный: вывод при погружении.
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         NaturalNumbers(n - 1);
//     }
//         else if (n < 0)
//          Console.WriteLine("Error: number is not natural! Please try again.");
   
// }

// Console.Write("Input a natural number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(n);

// void NaturalNumbers(int m, int n)  // второй способ, перегружающий оперативку, но мне ближе
// {
//     if (n >= m)
//     {
//         NaturalNumbers(m + 1, n);
//         Console.Write(m + " ");
//     }
//         else if (n < 0)
//          Console.WriteLine("Error: number is not natural! Please try again.");
   
// }

// Console.Write("Input a natural number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = 1;
// NaturalNumbers(m, n);




// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// int SumDigits(int numM, int numN)
// {
// 	if (numM > 0 && numN > 0)
// 	{
// 		if (numM < numN) return numM + SumDigits(numM + 1, numN);
// 		if (numM > numN) return numM + SumDigits(numM - 1, numN);
// 		else return numM;
// 	}
// 	return -1;
// }
// Console.Write("Input a first number: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your result: {SumDigits(numM, numN)}");



// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int FunctionAkkerman(int m, int n)
// {
//     if (m >= 0 && n >= 0)
//     {
//      if (m == 0) return n + 1;
//      if (n == 0) return FunctionAkkerman(m - 1, 1);
//         else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
//     }
//     return -1;
// }

// Console.Write("Input a first number: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"calculating the Ackerman function: {FunctionAkkerman(numM, numN)}");