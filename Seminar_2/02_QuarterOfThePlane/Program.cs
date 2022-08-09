// 2. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.

Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());
if ((x > 0) && (y > 0)) Console.WriteLine($"Точка ({x};{y}) находится в первой плоскости!");
else if ((x < 0) && (y > 0)) Console.WriteLine($"Точка ({x};{y}) находится во второй плоскости!");
else if ((x < 0) && (y < 0)) Console.WriteLine($"Точка ({x};{y}) находится в третьей плоскости!");
else if ((x > 0) && (y < 0)) Console.WriteLine($"Точка ({x};{y}) находится в четвёртой плоскости!");
else Console.WriteLine($"Числа x и y не должны быть равны нулю по условию задачи!");
