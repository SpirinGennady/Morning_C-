// Рекурсия. продолжение.
// Собрать числа от a до b, a<=b

// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <=b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// // теперь с помощью рекурсии

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return string.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// Собрать числа от a до b, a>=b

// string NumbersFor(int a, int b) // здесь лажа!
// {
//     string result = string.Empty;
//     for(int i = a; i >= b; i--)
//     {
//         result += $"{i} "; 
//     }
//     return result;
// }
 
// с помощью рекурсии!
// string NumbersRec(int a, int b)
// {
    // if(a <= b) return NumbersRec(a + 1, b) + $"{a} "; // условие возврата!
//     else return string.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// Сумма чисел от 1 до n.

// int SumFor(int n)
// {
//     int result = 0;
//     for(int i = 1; i <= n; i++) result +=i;
//     return result;
// }

// // с помощью рекурсии!
// int SumRec(int n)
// {
//     if(n == 0) return 0; // условие возврата!
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// Факториал числа n.

// int FactorialFor(int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= i;
// return result;
// }

// int FactorialRec(int n)
// {
//     if(n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// Вычислить a в степени n.

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     if(n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));

// int n = 1; // не работает!
// void FindWords(string alphabet, char[] word, int legth = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return; 
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[legth] = alphabet[i];
//         FindWords(alphabet, word, legth + 1);
//     }
// }
// FindWords("аисв", new char[2]);

//Вывод информации из папки

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"D:/Doc";
// CatalogInfo(path);

// Выстраивание детской пирамидки, с помощью двух пустых.

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// 1 аргумент - шпиль от куда, 2 - шпиль куда, 3 - темповый шпиль, 4 - сколько колец
{
    if (count < 1) Towers(with, some, on, count -1);
    // перемещаем с первой на вторую и т.д. 28.21
    Console.WriteLine($"{with} >> {on}");
    if (count < 1) Towers(some, on, with, count - 1);
}

Towers();