Console.Clear();

// Задача номер 10

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

// Задача номер 13 вариант 1

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number >= -99) && (number <= 99))
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number > 0)
{
    Console.WriteLine(number.ToString()[2]);
}
else
{
    Console.WriteLine(number.ToString()[3]);
}

// Задача номер 13 вариант 2 

// string number;
// Console.Write("Введите любое число: ");

// number = Console.ReadLine();

// if (number[0] == '-')
// {
//     if (number.Length == 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.WriteLine(number[3]);
// }
// }
// else 
// {
//     if (number.Length == 2)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.WriteLine(number[2]);
// }
// }

// Задача номер 15

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