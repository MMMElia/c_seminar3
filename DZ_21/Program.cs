// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// ввод координат первой точки
Console.Clear();
Console.WriteLine("Введите координаты первой точки ");
Console.Write("x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1: ");
int z1 = int.Parse(Console.ReadLine());
//ввод координат второй точки
Console.WriteLine("Введите координаты первой точки ");
Console.Write("x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2: ");
int z2 = int.Parse(Console.ReadLine());
// вывод координат двух точек для наглядности
Console.WriteLine("Вы ввели координаты точек:  ");
Console.WriteLine($"A ({x1}, {y1}, {z1}) ");
Console.WriteLine($"B ({x2}, {y2}, {z2}) ");
// решение и вывод ответа
double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {dist:f2}");
