// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray() 
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input a min possible value: ");
//     double minValue = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     double maxValue = Convert.ToDouble(Console.ReadLine());

//     double[,] array = new double[rows, columns];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().NextDouble(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(double[,] array) {
//     for(int i = 0; i < array.GetLength(0); i++) {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);




// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> элемента с такими индексами в массиве нет

// int[,] CreateRandom2dArray() {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array) {
//     for(int i = 0; i < array.GetLength(0); i++) {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int ReturnWithIndication(int[,] array, int num1, int num2)
// {
//   int[,] array = new int[num1, num2];
//   array[i,j] = 0;
//     if (i < array.GetLength(0) || j < array.GetLength(1))
//     {
//         Console.WriteLine("Error: there is no element with such indexes in the array!");
//     }
//     else
//     {
//         for(int i = 0; i < num1; i++)
//             for(int j = 0; j < num2; j++)
//             array[i, j] = result;
//     }
//     return result;
// }    

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// ReturnWithIndication( num1, num2);
// Console.WriteLine($"the value of the element at {num1} and {num2}: {result} ");



// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



