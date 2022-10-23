int SecondNumber(int number)
{
    int firstNumber = number /100;
    return (number - (firstNumber*100)) / 10; 
}
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondNumber(num));