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
//             array[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
            
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
//     Console.Write("Number of rows in the array: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Number of columns in the array: ");
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

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//     Console.WriteLine();
//     }
//     Console.WriteLine();

// }

// void ElementValue(int[,] arr, int row, int col)
// {
//     if (row>=1 && row<= arr.GetLength(0)
//         && col>=1 && col<= arr.GetLength(1))
//         Console.Write($"Element value with indexes [{row},{col}]: {arr[row,col]}");
//     else
//         Console.Write($"Error: there is no element with indexes [{row},{col}] in the array!");
// }
//     Console.Write("Input a number of row: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of column: ");
//     int column = Convert.ToInt32(Console.ReadLine());
   

//     int[,] newArray = CreateRandom2dArray();
//     Show2dArray(newArray);
//     ElementValue(newArray,row,column);



  

// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] CreateRandom2dArray() {
//     Console.Write("Number of rows in the array: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Number of columns in the array: ");
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

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//     Console.WriteLine();
//     }
//     Console.WriteLine();

// }

// double[] ArithmeticMeansOfNumbers(int[,] arr)
// {
//     double[] resultArray = new double[arr.GetLength(1)];
//     double sum = 0;

//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         sum = 0;    
//         for (int j = 0; j < arr.GetLength(0); j++)
//            sum += arr[j,i];
           
//         resultArray[i] = sum / arr.GetLength(0);
//     }  
    
//     return resultArray;
// }

// int[,] arr = CreateRandom2dArray();

// double[] arrArithmeticMeansOfNumbers = ArithmeticMeansOfNumbers(arr);

// Show2dArray(arr);

// Console.Write("Arithmetic mean of each column: ");
// for (int i = 0; i < arrArithmeticMeansOfNumbers.Length; i++)
//     Console.Write(Math.Round(arrArithmeticMeansOfNumbers[i], 1) + " ");