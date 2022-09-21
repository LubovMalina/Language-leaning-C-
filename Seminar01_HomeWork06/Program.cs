// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число нечетное");
}