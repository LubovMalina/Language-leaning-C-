Console.Clear();

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

double number_neg = -(number);

while (number_neg <= number)
{
   Console.WriteLine(number_neg);
   number_neg++; 
}
