Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int y = n;
int revers = 0;
if (n>9999 && n < 100000)Console.Write(Polindrom(n) == n ? "Да" : "Нет");
else Console.WriteLine("Число не пятизначное");
int Polindrom(int newnum)
{
    while (y > 0)
    {
        newnum = y % 10;
        revers = (revers * 10) + newnum;
        y = y / 10;
    }
    return revers;
}
