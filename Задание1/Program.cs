/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.WriteLine("Для сравнение двух чисел введите данные в консоль.");
Console.WriteLine("Введите число 1: ");
string ferstnum = Console.ReadLine() ?? "";

Console.WriteLine("Введите число 2: ");
string secondnum = Console.ReadLine() ?? "";

int a = Convert.ToInt32(ferstnum);
int b = Convert.ToInt32(secondnum);

int max = 0;
if (a>b) max = a;
else max = b;

Console.WriteLine($"Максимальное число равно: {max} ");
