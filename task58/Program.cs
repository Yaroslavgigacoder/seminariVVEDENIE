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

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {   
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {   
                matrix[i, j] = matrix[i, j] + (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }
    return matrix;
}
int[,] array2D1 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(array2D1);
Console.WriteLine();
int[,] array2D2 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(array2D2);
Console.WriteLine();
if(array2D1.GetLength(0)==array2D2.GetLength(1))
{
    int[,] multimatrix = MultiMatrix(array2D1, array2D2);
    PrintMatrix(multimatrix);
}
else Console.WriteLine("Матрицы нельзя перемножить.");
