// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// void ReverseArray(int[] array)
// {
   
//   for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//   { 
//      int temp = array[i];
//      array[i] = array[j];
//      array[j] = temp;
//     }
//   }
  
// Console.Write(" Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Input a max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// ReverseArray(newArray);
// ShowArray(newArray);



// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool IsTrianglePossible (int a, int b, int c) 
// {
//     return (a < b + c && b < a + c && c < a + b);
// }

// Console.Write("Input the length of the first side: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the length of the second side: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the length of the third side: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (IsTrianglePossible(a, b, c) == true) Console.WriteLine("A triangle is possible");
// else Console.WriteLine("A triangle is not possible");


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int[] Fibonacci(int N, int a, int b)
// {
//      int[] array = new int[N];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < N; i++)
//         array[i] = array[i-1] + array[i-2];
//     return array;
    
// }

// Console.Write("Input a first value: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second value: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of numbers in the sequence: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] array = Fibonacci(N, a, b);
// ShowArray(array);


// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

// int[] CopyArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//         result[i] = array[i];
//     return result;

// }
// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int[] newArray1 = CopyArray(newArray);
// ShowArray(newArray1);




// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


// 15 % 2 = 1
// 7 % 2 = 1
// 3 % 2 = 1
// 1 % 2 = 1 


// string ToBinary(int number)
// {
//     string result = string.Empty;
//     while (number > 0)
//     {
//         result = Convert.ToString(number % 2) + result;
//         number /= 2;
//     }
//     return result;
// }

// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string binary = ToBinary(number);
// Console.WriteLine(binary);