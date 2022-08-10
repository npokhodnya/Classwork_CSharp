// See https://aka.ms/new-console-template for more information

Console.Write("Введите число для проверки на палиндром: ");
int num = int.Parse(Console.ReadLine());
if (num > 9999 && num < 100000)
{   
    int palindromeNum = (num%10*10000)+((num%100-num%10)*100)+(num%1000-num%100)+((num%10000-num%1000)/100)+(num/10000);
    if (num == palindromeNum) Console.WriteLine($"Число {num} является палиндромом! ({num} = {palindromeNum})!");
    else Console.WriteLine($"Число {num} НЕ является палиндромом! ({num} != {palindromeNum})!");
}
else
{
    Console.WriteLine($"Число должно быть пятизначным!");
}
