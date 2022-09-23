// Напишите программу, которая принимает на вход координаты точки (Х и У),
// причем Х не равно 0 и У не равно 0 и выдаёт 
// номер четверти плоскости, в котрой находится эта точка. 

Console.WriteLine("Введите координаты точки: ");
Console.Write("X:  ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:  ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "Введены некоррекные координаты" : quarter);

string quarterStr = QuarterStr(xC, yC);
Console.WriteLine(quarterStr);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

string QuarterStr(int x, int y)
{
    if (x > 0 && y > 0) return 1 "Первая четверть";
    if (x < 0 && y > 0) return 2 "Вторая четверть";
    if (x < 0 && y < 0) return 3 "Третья четверть";
    if (x > 0 && y < 0) return 4 "Четвертая четверть";
    return "Введены некоррекные координаты";
}
