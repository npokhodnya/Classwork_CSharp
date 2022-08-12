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
Random rand = new Random();
int[] array = new int[] {rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61), rand.Next(-99, 61)};
Console.WriteLine($"Список до: ");
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Список после: ");
ChangeArray(array);
PrintArray(array);