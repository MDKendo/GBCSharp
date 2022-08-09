Console.Clear();

// Задача номер 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите любое трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100 || number > 1000)
// {
//     Console.WriteLine("Нужно трехзначное число, пробуй снова");
// }
// else
// {
// int num2 = number%100;
// int num3 = num2/10;
// Console.WriteLine(num3);
// }

// Задача номер 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Вариант 1

// Console.Write("Введите любое число, и я угадаю третью цифру: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number >= -99) && (number <= 99))
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else if (number > 0)
// {
//     Console.WriteLine(number.ToString()[2]);
// }
// else
// {
//     Console.WriteLine(number.ToString()[3]);
// }

// Задача номер 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Вариант 2 

Console.Write("Введите любое число, и я угадаю третью цифру : ");
string number = Console.ReadLine();
int num;
bool isnum = int.TryParse(number, out num); // пробуем вхождение значение number в целочисленные значения, есть ли в веденной строке цифры

if (isnum) // true в переменной bool и мы пошли проверять
{
    if ((number[0] == '-' && number.Length == 3) || (number[0] != '-' && number.Length == 2))
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number[0] == '-')
{
    Console.WriteLine(number[3]);
}
else 
{
    Console.WriteLine(number[2]);
}
}
else
{
    Console.WriteLine("Введены не цифры");
}

// Задача номер 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Выходной ли сегодня? ");
// Console.Write("Введи любой номер дня от 1 до 7: ");

// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//     Console.WriteLine("Таких дней нет, пробуй снова");
// }
// else
// {
//     if (day == 1)
//     {
//         Console.WriteLine("Понедельник - не выходной");
//     }
//     if (day == 2)
//     {
//         Console.WriteLine("Вторник - не выходной");
//     }
//     if (day == 3)
//     {
//         Console.WriteLine("It is Wednesday, my dudes - не выходной");
//     }
//     if (day == 4)
//     {
//         Console.WriteLine("Четверг - не выходной");
//     }
//     if (day == 5)
//     {
//         Console.WriteLine("Выдыхай, пятница");
//     }
//     if (day == 6)
//     {
//         Console.WriteLine("Суббота - ВЫХОДНОЙ");
//     }
//     if (day == 7)
//     {
//         Console.WriteLine("Воскресенье - ВЫХОДНОЙ");
//     }
// }