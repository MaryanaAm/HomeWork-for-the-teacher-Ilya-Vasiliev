/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число для проверки: ");
string number = Console.ReadLine() ?? "";

int num = Convert.ToInt32(number);

if(num%2 == 0)
    {
        Console.WriteLine($"Да,  {num} является четным числом.");
    }
else
    {
        Console.WriteLine($"Нет, {num} не является четным числом.");
    }