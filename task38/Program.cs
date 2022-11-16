double[] CreateArrayRndDouble(int len, int mx, int mn)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        double num = rnd.NextDouble() * (mx - mn) + mn;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
        if (i < array.Length - 1) Console.Write("|");
    }
    Console.WriteLine("]");
}
double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double Diff(double minnum, double maxnum)
{
    double difference = maxnum - minnum;
    return difference;
}


Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможный элемент массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможный элемент массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateArrayRndDouble(size, maximum, minimum);
PrintArray(arr);
double minnumber = MinNumber(arr);
double maxnumber = MaxNumber(arr);
double diff = Diff(minnumber, maxnumber);
Console.WriteLine($"Минимальный и максимальный элемент массива соответсвенно: {minnumber}|{maxnumber}");
Console.WriteLine($"Разница между максимальным и минимальным числом массива ={diff}");