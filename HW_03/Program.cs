// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AckermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
    return AckermanFunction(n, m);
}

int EnterData (string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = EnterData("введите первое натуральное число: ");
int m = EnterData("введите второе натуральное число: ");
Console.WriteLine(AckermanFunction(n, m));