// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный случайными числами из
// из промежутка {-9, 9}. 
// 2. Найдите сумму отрицательных и положительных элементов 
// массива.
// 3. Вывод результатов

// Например: В массиве [3,9,-8, 1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] CrateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeNegElem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i]; //sumNegative = sumNegative +array[i]
        else sumPositive += array[i]; // sumPositive = sumPositive +array[i]
    }
    return new int[] { sumPositive, sumNegative };
}

int[] arr = CrateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeNegElem = GetSumPositiveNegativeNegElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeNegElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositiveNegativeNegElem[1]}");