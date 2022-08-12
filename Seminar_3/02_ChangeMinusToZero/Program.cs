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
void FillArrayInt(int[] array, int min, int max)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(min, max+1);
        index++;
    }
}
int[] array = new int[10];
FillArrayInt(array, -99, 60);
Console.WriteLine("Список до: ");
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
Console.WriteLine("Список после: ");
PrintArray(array);