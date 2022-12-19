/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

bool areThereThreeDigits = false;
int number = 0;
while (!areThereThreeDigits)
{
Console.WriteLine("Введите трёхзначное число");
string numberStr = Console.ReadLine()??"";
number = int.Parse(numberStr);
if (number < 100 || number > 999)
{
    Console.WriteLine("Число должно быть трёхзначным");
}
else
areThereThreeDigits = true;
}

int digitTwo = ((number % 100) / 10);

Console.WriteLine($"Вторая цифра числа {number} равна {digitTwo}");
