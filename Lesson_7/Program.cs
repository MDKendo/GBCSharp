﻿Console.Clear();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Ведите количество строк массива: ");
// int stroki = int.Parse(Console.ReadLine());

// Console.Write("Ведите количество стобцов массива: ");
// int stolbi = int.Parse(Console.ReadLine());

// double [,] array = GetArray(stroki, stolbi);
// PrintArray(array);

// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m,n];
//     for (int i= 0; i< m; i++)
//     {
//         for (int j = 0; j<n; j++)
//         {
//             result[i,j] = Math.Round((new Random().NextDouble()*2-1.0)*10, 2);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i<inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Ведите строку: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Ведите столбец: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = new int[5, 5];
 
//             Random random = new Random();
//             for (int i = 0; i < 5; i++)
//             {
//                 for (int j = 0; j < 5; j++)
//                 {
//                     array[i, j] = random.Next(100);
//                 //    Console.Write("{0,4}", array[i, j]);
//                 }
//                 //Console.WriteLine();
//             }

// if (rows > array.GetLength(0) || columns > array.GetLength(1) || rows<= 0 || columns <= 0)
// {
//     Console.WriteLine("Такого числа в массиве нет");
// }
// else 
// {
//     Console.Write("{0,4}", array[rows-1, columns-1]);
// }




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Ведите количество строк массива: ");
int stroki = int.Parse(Console.ReadLine());

Console.Write("Ведите количество стобцов массива: ");
int stolbi = int.Parse(Console.ReadLine());

int [,] array = GetArray(stroki, stolbi);
PrintArray(array);
Summa(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i= 0; i< m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(0,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Summa(int[,] inArray)
{
    double sum = 0;
    for (int j = 0; j<inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum = sum + inArray[i,j];
        }
        Console.Write($"{(sum/inArray.GetLength(0)):N2}"+ ' ');
        sum = 0;
    }

}
