// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int Find_Number_Max(int number) // объявляем метод и количество переменных
// {
//      int edin = number % 10; // выделяем остаток
//      int sotni = number / 100; // удаляем остаток, крайние 2 цифры
//      int length_number = sotni * 10 + edin; // получаем число из 2 цифр

//      return length_number; // возвращаем результат метода
// }

// int Random_number = new Random().Next(100, 1000); // получаем трехзначное псевдослучайное число 
// int two_number = Find_Number_Max(Random_number); // запускаем метод, результат записываем в переменную

// // Console.WriteLine(Random_number); // показываем рандомное число для проверки
// Console.WriteLine($"После удаления второй цифры, осталось число: {two_number}"); // записываем результат




// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// int number = new Random().Next(100,1000);
// int RemoveSecondDigit(int number)
// {
//     int thirdDigit = number % 10;
//     int firstDigit = number / 100;
//     return firstDigit * 10 + thirdDigit;
// }
// int result = RemoveSecondDigit(number);
// Console.WriteLine($"Итоговое число от {number} => {result}");



// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// bool Aliqua(int arg1, int arg2)
// {
//     return arg1 % arg2 == 0;

// }
// if (Aliqua(number1, number2)) 
// Console.WriteLine($"{number1} кратно"{number2}");
// else Console.Write($"{number1} не кратно {number2}! Остаток: {number1 % number2}");


// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// int number = Convert.ToInt32(Console.ReadLine());

// bool IsAliquot(int arg)
// {
//     return arg / 7 == 0 && arg / 23 == 0;
// }
// if (IsAliquot(number)) Console.WriteLine("Да!");
// else Console.WriteLine("Нет!");
//     }
// }


// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int square = num2 * num2;

if (num1 == square)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// bool IsSquare(int num1, int num2)
// {
//     return num1 == num2 * num1 || num2 == num1 * num1;
// }
// if (IsSquare(number1, number2)) Console.WriteLine($"{number1}");