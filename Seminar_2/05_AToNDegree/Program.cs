// Возведите число А в натуральную степень B используя цикл.

int Degree(int num, int degree)
{
    int count = 1;
    int res = num;
    while (count<degree)
    {
        res*=num; 
        count++;
    }
    return res;
}

Console.Write("Введите число для возведения в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}^{n} = {Degree(a, n)}");