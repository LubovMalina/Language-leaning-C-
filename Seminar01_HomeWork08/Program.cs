//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int step = 2;

while (num>=step)
{
    Console.Write(step);
    step +=2; 
}


