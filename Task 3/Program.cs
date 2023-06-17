// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Введите номер дня недели: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());

// if ((DayWeek > 0) | (DayWeek < 8)) Лишнее, т.к. в конце добавлено else System.Console.WriteLine("Такого дня не существует");
{
    if (DayWeek == 1)
    System.Console.WriteLine("Сегодня Понедельник");
    else if (DayWeek == 2)
    System.Console.WriteLine("Сегодня Вторник");
    else if (DayWeek == 3)
    System.Console.WriteLine("Сегодня Среда");
    else if (DayWeek == 4)
    System.Console.WriteLine("Сегодня Четверг");
    else if (DayWeek == 5)
    System.Console.WriteLine("Сегодня Пятница");
    else if (DayWeek == 6)
    System.Console.WriteLine("Сегодня Суббота");
    else if (DayWeek == 7)
    System.Console.WriteLine("Сегодня Воскресенье");
    else
    System.Console.WriteLine("Такого дня не существует");
}