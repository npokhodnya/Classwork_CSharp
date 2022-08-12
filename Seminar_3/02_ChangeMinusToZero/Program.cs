// See https://aka.ms/new-console-template for more information

void ChangeArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        if (array[index] < 0) array[index] = 0;
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        if (count+1 == array.Length) Console.WriteLine($"{array[count]}!");
        else Console.Write($"{array[count]}, ");
        count++;
    }
}
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(-99, 61);
        index++;
    }
}
int[] array = new int[10];
FillArray(array);
Console.WriteLine("Список до: ");
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
Console.WriteLine("Список после: ");
PrintArray(array);