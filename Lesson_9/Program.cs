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

// Console.Write("Введите первое число: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int N = int.Parse(Console.ReadLine());
// int sum = 0;

// PrintNumbers(M,N);
// Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sum} ");

// void PrintNumbers(int x, int y)
// {
//     sum = sum + x;
//     if (x == y) return;
//     PrintNumbers(x+1, y);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
if (m < 0 || n < 0 || m >= 4|| n >= 4)
{
    Console.Write("Остановись подумай, твоя память не бесконечная! Функция только для неотрицательных!");
}

else
{
string otv = Akk(m, n).ToString();
Console.Write($"{otv}");

int Akk(int m, int n)
{
    if ( m == 0)
    {
        return n +1;
    }
    else if (n == 0 && m > 0 )
    {
        return Akk (m - 1, 1);
    }
    else 
    {
        return Akk (m -1, Akk (m,n -1));
    }
}
}