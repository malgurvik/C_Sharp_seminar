/*
Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход 
координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.Clear();
System.Console.WriteLine("Ведите координаты точки A (x, y, z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите координаты точки B (x, y, z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

//int squareX = (userBx - userAx) * (userBx - userAx);
double squareX = Math.Pow(userBx - userAx, 2);// Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double squareZ = Math.Pow(userBz - userAz, 2);
double rootXY = Math.Sqrt(squareX + squareY + squareZ);//Math.Sqrt() находит квадратный корень
System.Console.WriteLine(Math.Round(rootXY, 2));//Math.Round(a, 2) округление чисел после запятой(число, сколько чисел после запятой оставить)

// Version для автотеста
/*int xA = pointA[0];
int yA = pointA[1];
int zA = pointA[2];
int xB = pointB[0];
int yB = pointB[1];
int zB = pointB[2];

double squareX = Math.Pow(xB - xA, 2);
double squareY = Math.Pow(yB - yA, 2);
double squareZ = Math.Pow(zB - zA, 2);
double distance = Math.Sqrt(squareX + squareY + squareZ);
return distance;*/
