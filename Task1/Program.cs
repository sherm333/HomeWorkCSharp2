/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

int GetRandomNumber(int leftRange, int rightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange);
    return result;
}

int PrintSecondDigit(int number)
{
    int secondDigit = (number / 10) % 10;
    return secondDigit;
}

int number = GetRandomNumber(100,1000);
Console.WriteLine(number);

int secDigit = PrintSecondDigit(number);
Console.WriteLine(secDigit);

