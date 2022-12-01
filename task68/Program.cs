Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkerman(m, n));

int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return Akkerman(numM - 1, 1);
    if (numM > 0 && numN > 0) return (Akkerman(numM - 1, Akkerman(numM, numN - 1)));
    return Akkerman(numM,numN);
}