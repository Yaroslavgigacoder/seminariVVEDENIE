Console.Write("Введите 2 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a<b)
{
    Console.Write($"Большее число {b} ");
    Console.Write($"Меньшее число {a} ");
}
else
{
Console.Write($"Большее число {a} ");
Console.Write($"Меньшее число {b} ");
}