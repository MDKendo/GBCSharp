Console.Clear();

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.Write("Введите первое число: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int N = int.Parse(Console.ReadLine());

// PrintNumbers(M,N);

// void PrintNumbers(int x, int y)
// {
//     Console.Write($"{x} ");
//     if (x == y) return;
//     PrintNumbers(x+1, y);
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;

PrintNumbers(M,N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sum} ");

void PrintNumbers(int x, int y)
{
    sum = sum + x;
    if (x == y) return;
    PrintNumbers(x+1, y);
    
}