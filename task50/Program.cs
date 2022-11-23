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

void FindElement(int elementrows, int elementcolums, int[,] matrix)
{
    if (elementcolums < 0 && elementrows < 0) Console.Write("Индeксы введены не корректно");
    else Console.Write(elementrows < matrix.GetLength(0) && elementcolums < matrix.GetLength(1) ? "Такой элемент в массиве есть" : "Такого элемента нет");
}
Console.WriteLine("Введите индекс строки:");
int elemrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:");
int elemcolums = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(2, 3, -9, 9);
PrintMatrix(array2D);
FindElement(elemrows, elemcolums, array2D);