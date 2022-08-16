// Выяснить являются ли три числа сторонами треугольника.

void IsSidesOfRectangle(double side1, double side2, double side3)
{
    if((side1+side2>side3) && (side1+side3>side2) && (side2+side3>side1)) 
       {
        Console.WriteLine($"Строны {side1}, {side2} и {side3} могут являться сторонами треугольника!");  
       } 
    else Console.WriteLine($"Строны {side1}, {side2} и {side3} НЕ могут являться сторонами треугольника!");
}
// Другое решение:
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
bool CheckTriangle(double a, double b, double c) => a+b>c && b+c>a && a+c>b;
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Clear();
Console.Write("Ведите первую сторону треугольника: ");
var side1 = double.Parse(Console.ReadLine());
Console.Write("Ведите вторую сторону треугольника: ");
var side2 = double.Parse(Console.ReadLine());
Console.Write("Ведите третью сторону треугольника: ");
var side3 = double.Parse(Console.ReadLine());
// Решение 1:
Console.WriteLine("Решение 1:");
IsSidesOfRectangle(side1, side2, side3);
Console.WriteLine();
// Решение 2:
Console.WriteLine("Решение 2:");
Console.Write(CheckTriangle(side1, side2, side3) ? $"Строны {side1}, {side2} и {side3} могут являться сторонами треугольника!" : 
                                                   $"Строны {side1}, {side2} и {side3} НЕ могут являться сторонами треугольника!");