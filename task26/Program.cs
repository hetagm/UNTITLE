﻿// Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в силе.
// 456 -> 3
// 78 -> 2
// 89125 -> 5

Console.WriteLine("Введите цифры:  ");
int number = Convert.ToInt32(Console.ReadLine());

int QuantityNumbers(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}
int res = QuantityNumbers(number);
Console.WriteLine(res);



