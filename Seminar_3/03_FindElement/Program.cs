// Определить, присутствует ли в заданном массиве, некоторое число.

void FindElementInArray(int[] array, int element)
{
    int index = 0;
    int countElements = 0;
    while (index < array.Length)
    {
        if (array[index] == element)
        {
            Console.WriteLine($"Элемент {element} присутствует в этом массиве и занимает {index} индекс!");
            countElements++;
        }  
        index++;
    }
    if (countElements == 0) Console.WriteLine($"Элемента {element} НЕТ в этом массиве!");

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
void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        if (count+1 == array.Length) Console.Write($"{array[count]}!");
        else Console.Write($"{array[count]}, ");
        count++;
    }
}

int[] array = new int[10];
FillArrayInt(array, -99, 60);
Console.Write("Список: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число, которое хотите найти: ");
int element = int.Parse(Console.ReadLine());
FindElementInArray(array, element);