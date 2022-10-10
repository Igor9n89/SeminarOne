// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает *вторую* цифру этого числа.

Console.WriteLine("Приветствую! Введите трехзначное число: ");
int num  = int.Parse(Console.ReadLine()!);

int a1 = num%100;

int result = a1/10;

Console.WriteLine($"Вторая цифра {num} - {result}");



