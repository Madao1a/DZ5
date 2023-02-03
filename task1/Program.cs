// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = int.Parse(Console.ReadLine());
 
 
int x = -(b1 - b2) / (k1 - k2);
int y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
