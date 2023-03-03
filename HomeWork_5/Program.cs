// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue);

//    return array; 
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int EvenNumbers(int[] num)
// {
//     int length = num.Length;
//     int evenNumber = 0;

//     for (int i = 0 ; i < length; i++)
//     {
//         if(num[i]%2 == 0)
//         {
//             evenNumber++;
//         }
//     }
//     return evenNumber;
// }
// Console.Write(" Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a min three-digit number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a max three-digit number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = EvenNumbers(newArray);
// Console.WriteLine("number of even numbers " + result);


// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue);

//    return array; 
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumOddNumbers(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//             if(i%2 != 0)
//         {
//             sum = array[i] + sum; 
//         }
//         return sum;
// }

// Console.Write(" Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = SumOddNumbers(newArray);
// Console.WriteLine("sum of the elements standing in odd positions " + result);




// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue);

//    return array; 
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int MaxMinElements(int[] array)
// {
//     int maxNum = array[0];
//     int minNum = array[0];

//   for (int i = 1; i < array.Length; i++)
//   {
//     if (maxNum < array[i])
//     {
//       maxNum = array[i];
//     }
//         if (minNum > array[i])
//     {
//       minNum = array[i];
//     }
//   }
//     int decision = maxNum - minNum;
//   return decision;
//  }

// Console.Write(" Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = MaxMinElements(newArray);
// Console.WriteLine("difference between the max and min array elements " + result);


