// Console.Clear();

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int step = 1;

if (num<1)
{
    Console.WriteLine("Некорректный ввод");
}

else
{
    while (num>=step)
    {
        Console.WriteLine(Math.Pow(step,2));
        step++;
    }
}


