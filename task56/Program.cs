int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}
int[] SumElements(int[,] matrix)
{
    int[] summa = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        summa[i] = sum;
    }
    return summa;
}
int SumMinimum(int[] array)
{
    int indexmin=0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min) 
        {
            min = array[i];
            indexmin= i+1;
        }
    }
    return indexmin;
}
int[,] array2D = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(array2D);
int summin = (SumMinimum(SumElements(array2D)));
Console.Write($"Номер строки с найменьшей суммой = {summin}");
