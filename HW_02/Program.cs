// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int firstNumber, int secondNumber)
{
    if(firstNumber == secondNumber) return firstNumber;
    return (firstNumber + SumNumbers(++firstNumber, secondNumber));
}

int EnterData (string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int firstNumber = EnterData("введите первое натуральное число: ");
int secondNumber = EnterData("введите второе натуральное число: ");
Console.WriteLine(SumNumbers(firstNumber, secondNumber));