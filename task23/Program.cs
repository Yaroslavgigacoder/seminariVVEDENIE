Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
void table(int n)
{
    if (n > 0)
    {
        int current = 1;
        while (current <= n)
        {
            Console.WriteLine($"{current,5}|{current * current * current,5}");
            current++;
        
        }
    }
    else Console.WriteLine("Некорректное число");
}
table(n);