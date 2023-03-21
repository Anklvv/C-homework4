#pragma warning disable
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a, b;
Console.WriteLine($"Введите число A: ");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine($"Введите число B: ");
int.TryParse(Console.ReadLine(), out b);

int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int a;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine(), out a);
int sum = 0;

while (a > 0)

{
int num = a % 10;
a = a / 10;
sum = a + num;

}

Console.WriteLine("Cумма всех цифр в числе равна: " + sum);