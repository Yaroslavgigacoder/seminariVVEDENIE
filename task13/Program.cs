int Number(int number)
{
    while(number>1000)
    {
        number = number / 10;
    }   
    return number % 10;
}
int  num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number(num));