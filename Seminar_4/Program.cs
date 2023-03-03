// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int GetSum(int a)
// {
//     int sum = 0;
//     for(int current = 1; current <= a; current ++)
//         sum += current; // sum = sum + current;
//     return sum;
// }

// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(number);
// Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");


// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int Digits(int num)
// {
//     int digits = 0;
//     if(num == 0) digits = 1;
//     while(num != 0)
//     {
//         num /= 10;
//         digits++;
//     }
//     return digits;
// }
// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = Digits(number);
// Console.WriteLine($"number of digits {result} in the number {number}");




// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Multiplication(int n)
// {
//     int multip = 1;
//     for(int current = 1; current <= n; current++)
//         multip += current;
//         return multip;
// }
//  Console.Write("Input a number: ");
//  int number = Convert.ToInt32(Console.ReadLine());

//  int result = Multiplication(number);
//  Console.WriteLine($"when multiplying numbers from 1 to {number}, we get {result}");




// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue+1);
        
//     return array;
  
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write(" Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

