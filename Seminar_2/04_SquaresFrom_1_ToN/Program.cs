// Показать таблицу квадратов чисел от 1 до N.

Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while(count<=num)
{
    Console.WriteLine($"{count}^2 = {count*count}");
    count++;
}
