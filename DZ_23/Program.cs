// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"Таблица кубов числа {n}: ");
for ( int i=1; i<=n; i++) {
    Console.Write($"{Math.Pow(i,3)}, ");
}
