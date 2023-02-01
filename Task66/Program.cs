/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}


int getSummNumber(int M, int N)
{
    int summ = 0;
    if (M==N)
    {
        summ = M;
        return summ;  
    }
    summ = summ + M + getSummNumber(M +1, N);
    return summ;
}

int number_M = getUserData("Введите число M");
int number_N = getUserData("Введите число N");

int result = getSummNumber(number_M, number_N);

Console.WriteLine();
Console.WriteLine($"Сумма чисел от {number_M} до {number_N} = {result}");