Console.Clear();

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(M,N);

void PrintNumbers(int x, int y)
{
    Console.Write($"{x} ");
    if (x == y) return;
    PrintNumbers(x+1, y);
}