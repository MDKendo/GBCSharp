Console.Clear();

// Задача 41. Пользователь вводит с клавиатуры N чисел. Сколько чисел >0 ввел пользователь.

// int[] numbersToString(string stringArray)
// {
//     string[] num = stringArray.Split((' '), StringSplitOptions.RemoveEmptyEntries); //исключение пробела и деление на элементы
//     int[] result = new int[num.Length];
//     for (int i =0; i< result.Length; i++)
//     {
//         result[i] = int.Parse(num[i]);
//     }
//     return result;
// }

// int plusnumbers(int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item>0) count++;
//     }
//     return count;
// }

// Console.Write("Введите все числа через пробел: ");
// int[] numbers = numbersToString(Console.ReadLine());
// Console.WriteLine($"Положительных чисел => {plusnumbers(numbers)}");
// Console.WriteLine();


// Задача 43. Напишите программуб которая найдет точку пересечения двух прямых y=k1*x+b1, y=k2*x+b2 b1,k1,b2,k2 воодятся пользователем.

Console.Write("Введите через пробел значения b1, k1, b2, k2: ");
string[] point = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(point[0]);
double k1 = double.Parse(point[1]);
double b2 = double.Parse(point[2]);
double k2 = double.Parse(point[3]);

Console.WriteLine(String.Join(' ', GetPoint(b1, k1, b2, k2)));

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK1 - inK2);
    result[1] = inK1 *  result[0] + inB1;
    return result;
}