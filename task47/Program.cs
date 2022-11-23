double[,] CreateMatrixRndInt(int rows, int columns, int min,int max)
{
    double[,] matrix = new double[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i,j],2), 5} |");
            else Console.Write($"{Math.Round(matrix[i,j],2), 5}");
        }       
        Console.WriteLine("|");   
    }
}    
double[,] array2D=CreateMatrixRndInt(3,4,-9,9);
PrintMatrix(array2D);
