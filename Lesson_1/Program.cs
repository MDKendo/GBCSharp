// Первая задача

// Console.Clear();

// Console.Write("Загадай нормальное целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number ;

// Console.WriteLine("Число в квадрате: "+ sqrt);

// Вторая задача

Console.Write("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.Write("Первое число квадрат второго");
}
else
{
    Console.Write("Первое число не квадрат второго");
}