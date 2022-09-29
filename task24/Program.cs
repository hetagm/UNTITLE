﻿// Задача №24 Напишите программу, которая 
// 1)принимает на вход число (А) 
// и выдаеёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10 
// 8 -> 36

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int sumResult = SumNumbers2(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumResult}");

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int SumNumbers2(int num)
{
    int sum = default;
    counter = 1;
    while (counter <= num)
    {
        sum = sum + counter;
        counter++;
    }
    return sum;
}