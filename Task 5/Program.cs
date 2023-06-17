// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число: ");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (numberA > 99 && numberA < 1000)
{
numberA = numberA % 10;
Console.WriteLine("Последняя цифра: " + numberA);
}
else
{
Console.WriteLine("Введите корректное число от 1 до 999");
}
Console.ReadKey();
