// Первая задача

Console.Clear();

// Console.Write("Загадай нормальное целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number ;

// Console.WriteLine("Число в квадрате: "+ sqrt);

// Вторая задача

// Console.Write("Введи первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//     Console.Write("Первое число квадрат второго");
// }
// else
// {
//     Console.Write("Первое число не квадрат второго");
// }

// Третья задача

// Console.Write("Выбери номер дня: ");

// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//     Console.Write("Ты не знаешь сколько дней в неделе?");
// }
// else
// {
//     if (day == 1)
//     {
//         Console.Write("Понедельник");
//     }
//     if (day == 2)
//     {
//         Console.Write("Вторник");
//     }
//     if (day == 3)
//     {
//         Console.Write("Это среда мой друг");
//     }
//     if (day == 4)
//     {
//         Console.Write("Четверг");
//     }
//     if (day == 5)
//     {
//         Console.Write("Выдыхай, пятница");
//     }
//     if (day == 6)
//     {
//         Console.Write("Суббота");
//     }
//     if (day == 7)
//     {
//         Console.Write("Воскресенье");
//     }
// }

// Еще задача

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int y = num % 10;

// Console.WriteLine(y);

// Домашние задачки

// На вход два числа и выдает большее и меньшее.

// Console.WriteLine("Чтобы узнать какое число больше и меньше ");
// Console.Write("Введи первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2)
// {
//     Console.Write("Ты ввел два одинаковых числа");
// }
// else
// {
//     if (num1 > num2)
//     {
//         Console.WriteLine("Максимальное число: "+ num1);
//         Console.WriteLine("Минимальное число: " + num2);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное число: "+ num2);
//         Console.WriteLine("Минимальное число: " + num1);
//     }
// }

// Вход три числа и выдает максимальное

// Console.WriteLine("Чтобы узнать какое число больше");
// Console.Write("Введи первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     if (num1 > num3)
//     {
//         Console.Write("Самое большое число: " + num1);
//     }
//     else 
//     {
//         Console.Write("Самое большое число:" + num3);
//     }
// }
// else 
// {
//     if (num2 > num3)
//     {
//        Console.Write("Самое большое число: " + num2); 
//     }
//     else
//     {
//         Console.Write("Самое большое число: " + num3);
//     }
// }

// На вход число и выдает, является ли число четным

// Console.WriteLine("Четное ли число?");
// Console.Write("Введи число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 % 2 == 0)
// {
//     Console.Write("Твое число четное");
// }
// else
// {
//     Console.Write("Твое число не четное");
// }

// На вход число N, на выход все четные числа

// Console.WriteLine("Не знаю зачем, но тебе нужен список четных чисел до твоего числа, тогда");
// Console.Write("Введи число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// if (num1 <= 0)
// {
//     Console.Write("Можешь не указывать свое IQ, попробуй еще раз");
// }
// else
// {
//     while (count <= num1)
//     {
//         if (count % 2 == 0)
//         {
//             Console.Write(count + ",");
//             count = count+1;
//         }
//         else 
//         {
//             count = count+1;
//         }
//     }
// }

// Void

// void printQuarter(int a)
// {
//     if (a == 1)
//     {
//         Console.WriteLine("X > 0 & Y > 0");
//     }
//     else if (a == 2)
//     {
//         Console.WriteLine("X > 0 & Y < 0");
//     }
//     else if (a == 3)
//     {
//         Console.WriteLine("X < 0 & Y < 0");
//     }
//     else
//     {
//         Console.WriteLine("X < 0 & Y > 0");
//     }
// }

// Console.WriteLine("Введите четверть");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x >= 5 || x <= 0 )
// {
//     Console.WriteLine("Введите четверть");
// }
// else 
// {
//     printQuarter(x);
// }

// double legth_otr(int a, int b, int c, int d)
// {
//     int l = Math.Sqrt((a-c)*(a-c)+(b-d)*(b-d));
//     return l;
// }

// Console.WriteLine ("Введите х первой точки : ");
// int Xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите х первой точки : ");
// int Ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите х первой точки : ");
// int Xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите х первой точки : ");
// int Yb = Convert.ToInt32(Console.ReadLine());

// int Length = legth_otr(Xa, Ya, Xb, Yb);
// Console.ReadLine($"Расстояние между точками {Length}");

//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// int GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     } 
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Cумма цифр от 1 до введенного числа: {GetSumNums(num)}");


/*
Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
 */

int[] FillArray(int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(array[i] + " ");
    }
    return array;
}


void arrayReverse(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}

int[] arr = FillArray(10);
Console.WriteLine();
arrayReverse(arr);

foreach (int item in arr)
{
    Console.Write(item + " ");
}

/*
Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
 [1, -5, 8, 4, -9] -> 4.33
 
*/
double sum = 0;
int count = 0;

foreach (int item in arr)
{
    if (item > 0)
    {
        sum += item;
        count++;
    }
}
Console.WriteLine();

Console.WriteLine("sum = " + sum);
Console.WriteLine("count = " + count);
Console.WriteLine("foreach average: " + sum / count);

double average(int[] array)
{
    int count = 0;
    double sum = 0;
    foreach (int item in arr)
    {
        if (item > 0)
        {
            sum += item;
            count++;
        }
    }
    Console.WriteLine();

    Console.WriteLine("sum = " + sum);
    Console.WriteLine("count = " + count);
    return sum / count;
}

Console.WriteLine("method average = " + average(arr));
