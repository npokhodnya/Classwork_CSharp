// Написать программу преобразования десятичного числа в двоичное.

int From_10_To_2(int num)
{
    int binary = 0;
    for (int i = 0; num>=1; i++)
    {
        binary += num % 2 * (int)Math.Pow(10, i);
        num/=2;
    }
    return binary;
}
Console.Clear();
Console.Write("Введите число в десятичной сс: ");
var num = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат: {From_10_To_2(num)}");