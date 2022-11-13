int Prod(int A, int B)
{
    int voz = 1;
    for (int i = 0; i < B; i++)
    {
        voz *= A;
    }
    return voz;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int deg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(deg > 0 ?$"{Prod(num, deg)}"  : "Степень чилса не является натуральным числом");