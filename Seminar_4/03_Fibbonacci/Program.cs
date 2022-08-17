// Показать числа Фибоначчи меньшие заданного числа N.

void Fib(int n)
{
    int fibon1 = 0;
    int fibon2 = 1;
    Console.Write("0, 1, ");
    while (fibon2 <= n - fibon1)
    {
        int temp = fibon2;
        fibon2 = fibon2 + fibon1;
        fibon1 = temp;
        Console.Write(fibon2 + ", ");
    }
}
Console.Clear();
Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine());
Console.Write($"Результат: ");
Fib(num);