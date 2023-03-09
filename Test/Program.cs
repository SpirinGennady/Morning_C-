
// int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//      for (int i = 0; i < rows; i++)
//         for (int j = 0; j < colums; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     Console.WriteLine();
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

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
// Show2dArray(newArray);

//Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aij = i + j. Выведите полученный массив на экран.

// int[,] CreateArray(int rows, int colums)
// {
//     int[,] array = new int[rows,colums];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < colums; j++)
//     array[i,j] = i + j;

//     return array;
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int [,] newArray = CreateArray(rows, colums);
// Show2dArray(newArray);

// Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их квадраты.

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

// void ArraySquare(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i = i + 2)
//         for(int j = 0; j < array.GetLength(1); j = j + 2)
//     array[i, j] *= array[i, j];
// }

// int [,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// ArraySquare(newArray);
// Show2dArray(newArray);

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.

// int DiagonalSum(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//     result += array[i, i]; 

//     return result;
// }

// int [,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);

// int diagSum = DiagonalSum(newArray);
// Console.WriteLine($"Sum of elements on main diag is: {diagSum}");