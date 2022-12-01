/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Пожалуйста, последовательно введите три числа. ");
Console.WriteLine("Введите число 1: ");
string ferstnum = Console.ReadLine() ?? "";

Console.WriteLine("Введите число 2: ");
string secondnum = Console.ReadLine() ?? "";

Console.WriteLine("Введите число 3: ");
string thirdnum = Console.ReadLine() ?? "";

int a = Convert.ToInt32(ferstnum);
int b = Convert.ToInt32(secondnum);
int c = Convert.ToInt32(thirdnum);

int max = a;
if (a==b && b==c && c==a)
    {
        Console.WriteLine("Вы ввели одинаковые числа!");
    }

else
    {
    if(a > max) max = a;
    if(b > max) max = b;
    if(c > max) max = c;
    Console.WriteLine($"Максимальное число равно: {max} ");
    }
 





