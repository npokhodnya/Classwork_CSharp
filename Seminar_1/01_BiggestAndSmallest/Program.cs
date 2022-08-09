Console.Write("Ведите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write($"{a} > {b}");
}
if (a == b)
{
    Console.Write($"{a} = {b}");
}
if (a < b)
{
    Console.Write($"{a} < {b}");
}
