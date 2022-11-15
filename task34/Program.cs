int[] CreateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(99, 1000);
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
int Even(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;

}
Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(length);
PrintArray(arr);
int even = Even(arr);
Console.WriteLine(even > 0 ? $"Колличество четных чисел в массиве = {even} " : "Четных чисел в массиве нет");