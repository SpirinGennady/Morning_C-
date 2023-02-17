// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowDiapozon(int quad)
// {
//     if(quad == 1) Console.WriteLine("x > 0 and y > o");
//     else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quad == 4) Console.WriteLine("x < 0 and y > 0");
//     else Console.WriteLine("incorrect input!");
//  }

//  Console.Write("Input a number of quadrant: ");
//  int quadrant = Convert.ToInt32(Console.ReadLine());

//  ShowDiapozon(quadrant);




// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int AreaSquare(int x, int y)
// {
//     int square = 0;
//     if(x > 0 && y > 0) square = 1;
//     else if(x < 0 && y > 0) square = 2;
//     else if(x < 0 && y < 0) square = 3;
//     else if(x > 0 && y < 0) square = 4; 

//     return square;
// }

// Console.Write("Input meaning x: ");
// int pointX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input meaning y: ");
// int pointY = Convert.ToInt32(Console.ReadLine());

// int square = AreaSquare(pointX, pointY);

// Console.WriteLine($"Point wiht coordinate X = {pointX} Y = {pointY} located in the area of {square}");




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Distance(double xA, double yA, double xB, double yB)
// {
//     double hipotenuse = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
//     return hipotenuse;
// }

// Console.Write("Input first meaning x:");
// int pointXA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input first meaning y:");
// int pointYA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second meaning x: ");
// int pointXB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second meaning y: ");
// int pointYB = Convert.ToInt32(Console.ReadLine());

// double length = Distance(pointXA, pointYA, pointXB, pointYB);

// Console.WriteLine($"distance from point {pointXA}:{pointYA} to point {pointXB}:{pointYB} is {length} ");






// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void TablePrint(int num)
// {
//     int current = 1;
//     while(current <= num)
//     {
//         Console.WriteLine(current + " " + Math.Pow(current, 2));
//         current++;
//     }

// }
// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// TablePrint(number);