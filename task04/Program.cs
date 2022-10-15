Console.Write("Введите 3 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
{
    Console.WriteLine($"Максимальное число {a} ");
}
if (b>a && b>c)
{
    Console.WriteLine($"Максимальное число {b} ");
}
if (c>b && c>a)
{
    Console.WriteLine($"Максимальное число {c} ");
}