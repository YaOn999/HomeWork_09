// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NumbersInBetween(int number)
{
    if(number == 0) return number;
    Console.Write(number + ", ");
    return NumbersInBetween(number - 1);
}

int EnterData (string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("введите натуральное число: ");
NumbersInBetween(number);