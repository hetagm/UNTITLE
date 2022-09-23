// Напишите программу, которая по заданному номеру четверти, 
// показывает диапозон возможных координат точек в этой четверти (Х и У)

// System.Console.WriteLine("Введите четверть: ");
// int quater = Convert.ToInt32(Console.ReadLine());

// void Diaposon(int quater1)
// {
//     if (quater1 == 1) System.Console.WriteLine("x > 1, y > 1");
//     else if (quater1 == 2) System.Console.WriteLine("x < 0, y > 0");
//     else if (quater1 == 3) System.Console.WriteLine("x < 0, y < 0");
//     else if (quater1 == 4) System.Console.WriteLine("x > 0, y < 0");
//     else System.Console.WriteLine("Введите корректные данные");
// }
// Diaposon(quater);

Console.WriteLine("Введите четверть от 1 до 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = Quarter(quarter);
System.Console.WriteLine(result);

string Quarter (int quart)
{
    if(quart == 1) return "x > 1 && y > 1";
    if(quart == 2) return "x < 0 && y > 0";
    if(quart == 3) return "x < 0 && y < 0";
    if(quart == 4) return "x > 0 && y < 0";
    return "Введите корректное число";
}


