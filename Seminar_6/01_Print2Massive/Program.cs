// Показать двумерный массив размером m×n заполненный целыми числами.

void FillMatrix(int[,] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) array[i, j] = rand.Next(min, max+1);
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите число столбцов: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Введите число сторк: ");
var m = int.Parse(Console.ReadLine());
int[,] massive = new int[m, n];
FillMatrix(massive, 0, 9);
PrintMatrix(massive);