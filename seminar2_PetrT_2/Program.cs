// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

if (number >= 100 && number < 1000)
{
    Console.WriteLine("Третья цифра: {0}", number % 10);
}

if (number >= 1000 && number < 10000)
{
    Console.WriteLine("Третья цифра: {0}", number % 100 / 10);
}

if (number >= 10000 && number <100000)

{
    Console.WriteLine("Третья цифра: {0}", number % 1000 / 100);
}