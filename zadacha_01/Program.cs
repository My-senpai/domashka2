/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число") ??"";
string numStr = Console.ReadLine();
int num = Convert.ToInt32(numStr);

int result = num / 10;
int final = result % 10;
Console.WriteLine($"вторая цифра числа {num} - это {final}");