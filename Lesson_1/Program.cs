// Первая задача

// Console.Clear();

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

Console.Write("Выбери номер дня: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Ты не знаешь сколько дней в неделе?");
}
else
{
    if (day == 1)
    {
        Console.Write("Понедельник");
    }
    if (day == 2)
    {
        Console.Write("Вторник");
    }
    if (day == 3)
    {
        Console.Write("Это среда мой друг");
    }
    if (day == 4)
    {
        Console.Write("Четверг");
    }
    if (day == 5)
    {
        Console.Write("Выдыхай, пятница");
    }
    if (day == 6)
    {
        Console.Write("Суббота");
    }
    if (day == 7)
    {
        Console.Write("Воскресенье");
    }
}
