// Напишите программу, которая принимает на входе 
// координаты точек и находит расстояние между ними в 2D пространстве. 

// A (3,  6); B(2,  1) -> 5,09
// A (7, -5); B(1, -1) -> 7,21

// Math.Pow(2, 10);
// double num = Math.Sqrt(10);
// //  5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

Console.WriteLine("Введите x1:  ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1:  ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2:  ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:  ");
double y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int arg1, int arg2, int arg3, int arg4)
{
    double res1 = arg3 - arg1;
    double res2 = arg4 - arg2;
    double result = Math.Sqrt(Math.Pow(res1, 2) + Math.Pow(res2), 2);
    return result;
}
double res = Math.Round(Distance(x1, x2, y1, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);



