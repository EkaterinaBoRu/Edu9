/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

int ack(int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return ack(m-1, 1);
    return ack(m-1, ack(m, n-1));
}

int number_m = getUserData("Введите число m");
int number_n = getUserData("Введите число n");

int result = ack(number_m, number_n);
Console.WriteLine();
Console.WriteLine($"A({number_m}, {number_n}) = {result}");
