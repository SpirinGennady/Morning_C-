// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) &&
//     row2 >= 0 && row2 < array.GetLength(0) &&
//     row1 != row2 )
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//         int temp = array[row1, j];
//         array[row1, j] = array[row2, j];
//         array[row2, j] = temp;
//         }
//     }

// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);

// Console.Write("Input a first row for chenging: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1; // так как строка и индекс отличаются на 1, - отнимаем!
// Console.Write("Input a second row for chenging: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1; // так как строка и индекс отличаются на 1, - отнимаем!

// ChangeRows(newArray, r1, r2);
// Show2dArray(newArray);

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

//    1 2 3
//    4 5 6
//    7 8 9
                
//    2 5 8
//    3 6 9

// void TranportArray(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++) 
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//         int temp = array[i, j];
//         array[i, j] = array[j, i];
//         array[j, i] = temp;
//             }
//     } else
//         Console.WriteLine("Unable to transport array!");
// Console.WriteLine();
// }

// int [,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// TranportArray(newArray);
// Show2dArray(newArray);



// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// int[] FindMinPosition(int[,] array){
//     int[] result = new int[2];

//     for ( int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         if ( array[i, j] < array[result[0], result[1]]){
//             result[0] = i;
//             result[1] = j;
//         }
//     return result;
 
// }

// int[,] RemoveRowAndColums(int[,] array, int row, int col){
//     int[,] result = new int[array.GetLength(0) -1, array.GetLength(1) - 1];

//     for (int i = 0, newI = 0; i < array.GetLength(0); i++)
//         if (i != row) {
//             for (int j = 0, newJ = 0; j < array.GetLength(1); j++)
//                 if (j != col){
//                     result[newI, newJ] = array[i, j];
//                     newJ++;
//                 }
//             newI++;
//         }
//     return result;
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);

// int[] minPosition = FindMinPosition(array);

// int[,] newArray = RemoveRowAndColums(array, minPosition[0], minPosition[1]);
// Show2dArray(newArray);