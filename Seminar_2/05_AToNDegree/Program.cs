// Возведите число А в натуральную степень B используя цикл.

Console.Write("Введите число для возведения в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
int res = a;
while (count<n)
{
    res*=a; 
    count++;
}
    
Console.WriteLine($"{a}^{n} = {res}");