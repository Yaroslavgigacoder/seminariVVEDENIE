int[] CreateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}
int Positiv(int[] array)
{   
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(M);
PrintArray(arr);
Console.Write($"Колличество положительных чисел в массиве = {Positiv(arr)} ");