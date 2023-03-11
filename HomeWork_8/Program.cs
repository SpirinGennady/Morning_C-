// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// void SortForMin(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//          {
//              for (int k = 0; k < array.GetLength(1) - 1; k++)
//        {
//              if (array[i, k] < array[i, k + 1])
//         {
//                  int temp = array[i, k + 1];
//                 array[i, k + 1] = array[i, k];
//                 array[i, k] = temp;
//          }
//         }
//         }
//     }
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// SortForMin(newArray);
// Show2dArray(newArray);


// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


// int[] SumMinRow(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             sumArray[i] += array[i,j];  
//     return sumArray;
// }
// int GetNumRowMinSum(int[,] array)
// {
//     int[] sumArray = SumMinRow(array);
//     int iMinSum = 0;
//     for (int  i= 1; i < sumArray.Length; i++)
//         if (sumArray[i] < sumArray[iMinSum])
//             iMinSum = i;
//     return iMinSum + 1;
// }
// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// Console.WriteLine("Row number with minimum sum of elements: " + GetNumRowMinSum(array));


    


// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


// int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
// {
//     int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < newMatrix.GetLength(0); i++)
//         for (int j = 0; j < newMatrix.GetLength(1); j++)
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//                 newMatrix[i,j] += matrix1[i, k] * matrix2[k, j];
//     return newMatrix;
// }
// bool CheckMultiplication(int[,] matrix1, int[,] matrix2)
// {
//     if (matrix1.GetLength(1) == matrix2.GetLength(0))
//      return true;
    
//     return false;
// }
// Console.WriteLine("First matrix parameters:");
// int[,] matrix1 = CreateRandom2dArray();
// Console.WriteLine("Second matrix parameters:");
// int[,] matrix2 = CreateRandom2dArray();
// Console.WriteLine("Matrix 1:");
// Show2dArray(matrix1);
// Console.WriteLine("Matrix 2:");
// Show2dArray(matrix2);
// if (CheckMultiplication(matrix1, matrix2))
// {
//     Console.WriteLine("The result of multiplying matrix 1 by matrix 2:");
//     Show2dArray(MatrixMult(matrix1, matrix2));
// }
// else
//     Console.WriteLine("Error: these matrices cannot be multiplied!");


// Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateRandom3dArray()
// {
//     int x = 0;  
//     while (x <= 0)
//     {
//         Console.Write("Input array size x: ");
//         x = Convert.ToInt32(Console.ReadLine());
//         if (x <= 0) Console.Write("Error: invalid array size x!");
//     }
//     int y = 0;  
//     while (y <= 0)
//     {
//         Console.Write("Input array size y: ");
//         y = Convert.ToInt32(Console.ReadLine());
//         if (y <= 0) Console.Write("Error: invalid array size y!");
//     }
//     int z = 0;  
//     while (z <= 0)
//     {
//         Console.Write("Input array size z: ");
//         z = Convert.ToInt32(Console.ReadLine());
//         if (z <= 0) Console.Write("Error: invalid array size z!");
//     }
//     int amountNumbers = 0, minValue = 1, maxValue = 0, countElements = x*y*z;
//     while (amountNumbers < countElements)
//     {
//         while (maxValue < minValue)
//         {
//             Console.Write("Input a min value: ");
//             minValue = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Input a max value: ");
//             maxValue = Convert.ToInt32(Console.ReadLine());
//             if (maxValue < minValue) Console.WriteLine("Error: the maximum value is less than the minimum value!!!");
//         }
        
//         amountNumbers = maxValue - minValue + 1;
        
//         if (amountNumbers < countElements)
//         {
//             Console.WriteLine("Error: the number of possible unique values between min and max is less than necessary!!!");
//             maxValue = 0; minValue = 1;
//         }
//     }
//     int[,,] array = new int[x, y, z];
//     for (int i = 0; i < x; i++)
//         for (int j = 0; j < y; j++)
//             for (int k = 0; k < z; k++)
//             {
//                 int value = minValue - 1; 
//                 while (value == minValue - 1 || ContainedIn3dArray(array, value))
//                     value =  new Random().Next(minValue, maxValue+1);
    
//                 array[i,j,k] = value; 
//             }
//     return array;
// }
// bool ContainedIn3dArray(int[,,] array, int value)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)
//                 if (array[i,j,k] == value)
//                     return true;
//     return false;
// }
// void Show3dArray(int[,,] array)
// {
//     for (int k = 0; k < array.GetLength(2); k++)  
//         for(int i = 0; i < array.GetLength(0); i++)       
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 Console.Write(array[i,j,k] + $"({i},{j},{k})" + " ");
//             Console.WriteLine();
//         }
//     Console.WriteLine();
// }
// int[,,] array = CreateRandom3dArray();
// Show3dArray(array);

// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] CreateSpiralArray()
// {
//     int rows = 0;  
//     while (rows <= 0)
//     {
//         Console.Write("Input the number of array rows: ");
//         rows = Convert.ToInt32(Console.ReadLine());
//         if (rows <= 0) Console.Write("Error: invalid number of rows! ");
//     }
//     int colums = 0;  
//     while (colums <= 0)
//     {
//         Console.Write("Input the number of array columns: ");
//         colums = Convert.ToInt32(Console.ReadLine());
//         if (colums <= 0) Console.Write("Error: invalid number of columns! ");
//     }
//     int[,] array = new int[rows, colums];
//     int i = 0, j = 0, count = 0, value = 1, countElements = rows * colums;
//     while (value <= countElements)
//     {
//         while (j < colums - count && value <= countElements)
//         {
//             array[i,j] =  value;
//             value++;
//             j++;
//         }
//         j--; i++;
//         while (i < rows - count  && value <= countElements)
//         {
//             array[i,j] =  value;
//             value++;
//             i++;   
//         }
//         i--; j--;
//         while (j >= count && value <= countElements)
//         {
//             array[i,j] =  value;
//             value++;
//             j--;
//         }
//         j++; i--;
//         while (i > count  && value <= countElements)
//         {
//             array[i,j] =  value;
//             value++; 
//             i--;
//         }
//         i++; j++; count++;
//     }
//     return array;
// }
// int CountDig(int num)
// {
//     if (num == 0) return 1;
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
    
//     return count;
// }
// void ShowSpiralArray(int[,] array)
// {
//     int maxElement = array.GetLength(0) * array.GetLength(1);
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int CountZero = CountDig(maxElement) - CountDig(array[i,j]);
//             string zeroString = string.Empty;
//             for(int k = 0; k < CountZero; k++)
//                 zeroString = zeroString + "0";
//             Console.Write(zeroString + array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] newArray = CreateSpiralArray();
// ShowSpiralArray(newArray);

