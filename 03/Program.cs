/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
string numberStr = Console.ReadLine() ?? "";
int number = int.Parse(numberStr);

if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}