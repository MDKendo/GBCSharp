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

Console.WriteLine("Не знаю зачем, но тебе нужен список четных чисел до твоего числа, тогда");
Console.Write("Введи число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num1 <= 0)
{
    Console.Write("Можешь не указывать свое IQ, попробуй еще раз");
}
else
{
    while (count <= num1)
    {
        if (count % 2 == 0)
        {
            Console.Write(count + ",");
            count = count+1;
        }
        else 
        {
            count = count+1;
        }
    }
}