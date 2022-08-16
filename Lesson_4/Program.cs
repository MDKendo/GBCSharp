Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Это если по нормальному)
// Console.WriteLine ("Введите число А: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// if (numA != 0 && numB != 0)
// {
//     Console.Write($" Число {numA} в степени {numB} = {Math.Pow(numA,numB)} ");
// }
// else 
// {
//     Console.Write("Не используйте 0");
// }

// Это если всетаки цикл
Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int stepen = numA;
int count = 1;
double otvet = 0;
if (numB == 0)
{
    Console.WriteLine("Любое число в степени 0 = 1");
}
else if (numB > 0)
{
    while (count < numB)
   {
        stepen = stepen * numA;
        count++;
    }
    Console.WriteLine($" Число {numA} в степени {numB} = {stepen}");
}
    else
{
     numB = -numB;
     while (count < numB)
   {
        stepen = stepen * numA;
        count++;
    }
    Console.WriteLine($" Число {numA} в степени {-numB} = {(double)1/stepen}");
}


// Задача номер 27. напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string number = Convert.ToString(num);
// int summa = 0;
// summa = number [0] + number [1] + number [2] + number [3] + number [4] + number [5];
// Console.WriteLine(summa);