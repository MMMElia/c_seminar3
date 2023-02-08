// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a<10000 || a>99999) {
    Console.Write("Неверный ввод, введите пятизначное число: ");
    a = int.Parse(Console.ReadLine());
}

int a1=a/10000; 
int b1=a%10000;
// Console.WriteLine(a1); Console.WriteLine(b1); //проверка

int a2=b1/1000; 
int b2=b1%1000;
// Console.WriteLine(a2); Console.WriteLine(b2); //проверка

int a3=b2/100; 
int b3=b2%100;
// Console.WriteLine(a3); Console.WriteLine(b3); //проверка

int a4=b3/10; 
int a5=b3%10;
// Console.WriteLine(a4); Console.WriteLine(a5); //проверка

if (a1==a5 && a2==a4) {
    Console.Write("Ответ ДА ");
}
else {
    Console.Write("Ответ НЕТ");
}