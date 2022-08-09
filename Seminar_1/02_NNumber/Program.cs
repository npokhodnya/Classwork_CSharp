Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while(count<num)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
