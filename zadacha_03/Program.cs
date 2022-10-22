/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
System.Console.WriteLine("Введите число от 1 до 7");
string numStr = Console.ReadLine() ??"";
int num = Convert.ToInt32(numStr);

if (num > 0 && num < 8)
{
    if (num >5)
    {
        System.Console.WriteLine("сегодня выходной");
    }
    else 
    {
        System.Console.WriteLine("сегодня рабочий день");
    }
    
}
else
{
    System.Console.WriteLine("не верное число");
}