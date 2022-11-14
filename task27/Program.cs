int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int newnum = num % 10;
        sum += newnum;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр заданного числа = {SumNum(number)}");