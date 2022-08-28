Console.Clear();

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Палиндром или нет?");
// Console.WriteLine("Введите любое пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 0)
// {
// number = number * -1;
// }
//     if (number > 9999  && number < 100000)
//     {
//         string pal = Convert.ToString(number);
//         if (pal[0] == pal[4] && pal[1] == pal[3])
//         Console.WriteLine("Это число палиндром");
//         else
//     {
//         Console.WriteLine("Это число не палиндром");
//     }
//     }

// else 
// {
//     Console.WriteLine("Пятизначное, это из пяти цифр");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double legth_otr(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
// {
//     double l = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
//     return l;
// }
// Console.WriteLine ("Чтобы найти расстояние между точками введите их координаты по осямь X, Y, Z");
// Console.WriteLine ("Введите х первой точки : ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите y первой точки : ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите z первой точки : ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите x второй точки : ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите y второй точки : ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите z второй точки : ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double Length = legth_otr(X1, Y1, Z1, X2, Y2, Z2);
// double otv = Math.Round(Length, 2);
// Console.WriteLine($"Расстояние между точками {otv}");

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine ("Найти все кубы до любого числа");
// Console.WriteLine ("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<0)
// {
// for (int i = 1; i >= num; i--)
// {
//     Console.Write($"{Math.Pow(i,3)}, ");
// }
// }
// else for (int i = 1; i <= num; i++)
// {
//     Console.Write($"{Math.Pow(i,3)}, ");
// }

Console.WriteLine ("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int stepen = numA;
for (int count = 1; count == numB; count ++)
{
    stepen = stepen + stepen * numA;
    Console.WriteLine(stepen);
}