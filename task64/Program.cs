Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
NaturalNumber(num);

void NaturalNumber(int number)
{
    if (number==0) return;
    Console.Write($"{number} ");
    NaturalNumber(number-1);
}
