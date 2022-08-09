// 1. Дано число. Проверить кратно ли оно 7 и 23.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num%23 == 0) && (num%7 == 0)) Console.WriteLine($"Число {num} кратно 23 и 7!");
else if (num%23 == 0) Console.WriteLine($"Число {num} кратно только 23!");
else if (num%7 == 0) Console.WriteLine($"Число {num} кратно только 7!");
else Console.WriteLine($"Число {num} не кратно ни 23, ни 7!");
