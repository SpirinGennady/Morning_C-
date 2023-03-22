// Напишите программу, которая из массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer"] -> ["-2"]
// ["Nice", "Hand", "Record"] -> []


string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
void SampleArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SampleArray(array1, array2);
PrintArray(array2);