Console.WriteLine("Введите координаты точки A");
Console.Write("X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double dist = Math.Sqrt((b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2) + (b3 - a3) * (b3 - a3));
    return dist;
}