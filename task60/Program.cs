int[,,] CreateMatrixRndInt(int rows, int columns, int depth ,int min, int max)
{
    int[,,] matrix = new int[rows, columns,depth];
    Random rnd = new Random();
    int count=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = 10+count++;
            }
        }
        count++;
    }
    count++;
    return matrix;
}

void PrintArray3D (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]} ({i},{j},{k}) ");
      }
    }
    Console.WriteLine();
  }
}
int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 100);
PrintArray3D(array3D);