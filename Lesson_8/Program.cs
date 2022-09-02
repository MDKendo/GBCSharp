Console.Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Write("Ведите количество строк массива: ");
int stroki = int.Parse(Console.ReadLine());

Console.Write("Ведите количество стобцов массива: ");
int stolbi = int.Parse(Console.ReadLine());

int [,] array = GetArray(stroki, stolbi);
PrintArray(array);
sort(array);
Console.WriteLine();
PrintArray(array);

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

void PrintArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void sort(int[,] array)
{
   for(int i = 0; i<array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int t = j+1; t < array.GetLength(1); t++)
             {
                if (array[i,t]>array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }

             }
        }
    }
}