// Задать массив из 8 элементов и вывести их на экран.

void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        if (count+1 == array.Length)
        {
            Console.Write($"{array[count]}!");
        }
        else
        {
            Console.Write($"{array[count]}, ");
        }
        count++;
       
    }
}

Random rand = new Random();
int[] array = new int[] {rand.Next(1, 9999), rand.Next(1, 9999), rand.Next(1, 9999), rand.Next(1, 9999), rand.Next(1, 9999), rand.Next(1, 9999), rand.Next(1, 9999), rand.Next(1, 9999)};
PrintArray(array);

