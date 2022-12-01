Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

void SummaNumbers(int numM,int numN,int sum)
{   
    if (numM>numN) 
    {
        Console.WriteLine($"Сумма равна {sum}");
        return;
    }
    sum=sum+numM++;
    SummaNumbers (numM,numN,sum);  
}
if(m<n) SummaNumbers(m,n,0);
else SummaNumbers(n,m,0);