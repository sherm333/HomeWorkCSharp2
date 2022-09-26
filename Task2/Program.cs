/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString(); 

if (str.Length > 2)
    Console.WriteLine($"Третья цифра заданного числа - {str[2]} ");
else
    Console.WriteLine("Третьей цифры нет");