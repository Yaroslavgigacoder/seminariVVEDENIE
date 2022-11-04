Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int revers = 0;
int newnum = 0;
if (n > 9999 && n < 100000) Console.Write(Polindrom(n) == n ? "Да" : "Нет");
else Console.WriteLine("Число не пятизначное");
int Polindrom(int y)
{
    while (y > 0)
    {
        newnum = y % 10;
        revers = (revers * 10) + newnum;
        y = y / 10;
    }
    return revers;
}
