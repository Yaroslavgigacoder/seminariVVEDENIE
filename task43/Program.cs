Console.WriteLine("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(k1 == k2 ? "Прямые не пересекаются" : $"Точка пересечения {IntersectionX(k1, k2, b1, b2)}; {IntersectionY(k1, k2, b1, b2)}");
double IntersectionX(double o1, double o2, double p1, double p2)
{
    double x = (p1 - p2) / (o2 - o1);
    return x;
}
double IntersectionY(double o1, double o2, double p1, double p2)
{
    double y = (o2 * p1 - o1 * p2) / (o2 - o1);
    return y;
}
