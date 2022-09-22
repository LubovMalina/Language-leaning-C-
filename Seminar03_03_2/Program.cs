Console.Clear();

Console.WriteLine("Введите значение для точки А по оси х: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для точки А по оси y: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для точки B по оси х: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для точки B по оси y: ");
int yb = int.Parse(Console.ReadLine());

double num = Math.Sqrt((Math.Pow((xb-xa),2))+(Math.Pow((yb-ya),2)));
// d = √(xb - xa)2 + (yb - ya)2 =

Console.Write("Расстояние между точками = ", num);
Console.Write(num);