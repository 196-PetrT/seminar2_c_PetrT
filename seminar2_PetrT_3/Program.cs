// Напишите программу, которая принимает на вход цифру от 1 до 7, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру: ");
    int dayWeek = int.Parse(Console.ReadLine());
if (dayWeek >= 1 && dayWeek < 8)
{
    switch (dayWeek)
    {
        case 1:
            Console.Write("не выходный день");
            break;
        case 2:
            Console.Write("не выходный день");
            break;
        case 3:
            Console.Write("не выходный день");
            break;
        case 4:
            Console.Write("не выходный день");
            break;
        case 5:
            Console.Write("не выходный день");
            break;
        case 6:
            Console.Write("выходный день");
            break;
        case 7:
            Console.Write("выходный день");
            break;
    }
}
else
{
    Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
}
