Console.Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.Write("Ведите количество строк массива: ");
// int stroki = int.Parse(Console.ReadLine());

// Console.Write("Ведите количество стобцов массива: ");
// int stolbi = int.Parse(Console.ReadLine());

// int [,] array = GetArray(stroki, stolbi);
// PrintArray(array);
// sort(array);
// Console.WriteLine();
// PrintArray(array);

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m,n];
//     for (int i= 0; i< m; i++)
//     {
//         for (int j = 0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(0,10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void sort(int[,] array)
// {
//    for(int i = 0; i<array.GetLength(0); i++)
//    {
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//              for (int t = j+1; t < array.GetLength(1); t++)
//              {
//                 if (array[i,t]>array[i,j])
//                 {
//                     int temp = array[i,j];
//                     array[i,j] = array[i,t];
//                     array[i,t] = temp;
//                 }

//              }
//         }
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Ведите количество строк массива: ");
// int stroki = int.Parse(Console.ReadLine());

// Console.Write("Ведите количество стобцов массива: ");
// int stolbi = int.Parse(Console.ReadLine());

// int [,] array = GetArray(stroki, stolbi);
// PrintArray(array);

// Console.WriteLine($"Строка с наименьшей суммой {(MinSum(array)+1)}");


// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m,n];
//     for (int i= 0; i< m; i++)
//     {
//         for (int j = 0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(0,10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int MinSum (int [,] array)
// {
//     int mstroka = 0;
//     int minsumm = 0;
//     for (int i = 0; i<array.GetLength(1); i++)
//     {
//         minsumm = minsumm + array[0,i];
//     }

//     for (int i = 1; i<array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if (minsumm > sum)
//         {
//             minsumm = sum;
//             mstroka = i;
//         }
//     }
//     return mstroka;
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.WriteLine("Задайте две матрицы");
// Console.Write("Ведите количество строк матриц: ");
// int stroki = int.Parse(Console.ReadLine());

// Console.Write("Ведите количество стобцов матриц: ");
// int stolbi = int.Parse(Console.ReadLine());

// int [,] arrayA = GetArray(stroki, stolbi);
// int [,] arrayB = GetArray(stroki, stolbi);
// PrintArray(arrayA);
// Console.WriteLine();
// PrintArray(arrayB);
// Console.WriteLine("Произведение двух матриц");
// PrintArray(twoMatrix(arrayA,arrayB));

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m,n];
//     for (int i= 0; i< m; i++)
//     {
//         for (int j = 0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(0,10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] twoMatrix(int[,] arrayA, int [,] arrayB)
// {
//     int [,] arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i<arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j<arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k<arrayA.GetLength(1); k++)
//             {
//                 arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
//             }
//         }
//     }
//     return arrayC;
// }