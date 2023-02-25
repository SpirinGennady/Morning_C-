// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

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

// int NegativeArray(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//             if(array[i] < 0)
//             sum += array[i];
//         return sum;
// }

// Console.Write(" Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = NegativeArray(newArray);
// Console.WriteLine("Sum of negative is " + result);



// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

// int[] ReplaceElement(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] *= -1;

//         return array;
// }
// int[] array = CreateRandomArray(10, -6, 6);
// ShowArray(array);

// int[] newArray = ReplaceElement(array);

// ShowArray(newArray);



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

// bool FindElement(int[] array, int element)
// {
//     for(int i = 0; i < array.Length; i++)
//      if(array[i] == element)
//         return true;
    
//      return false;
// }   
// int[] array = CreateRandomArray(10,-10,10);
// ShowArray(array);

// Console.Write("Input a number for chekin: ");
// int element = Convert.ToInt32(Console.ReadLine());

// bool elementExist = FindElement(array, element);
//     if (elementExist)
//     Console.Write($"number {element} is in the array.");
//     else
//     Console.Write($"number {element} is not in the array.");





// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int NumberOfElement(int[] array, int a, int b)
// {
//     int result = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] >= a && array[i] <= b)
//          result++;
//     return result;
// } 

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

// Console.Write("Input a quartity number: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min posible value:  ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max posible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a pount a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a pount b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int elementInRange = NumberOfElement(newArray, a, b);
// Console.WriteLine($"the number of array elements {elementInRange} in the segment {a} : {b} ");

