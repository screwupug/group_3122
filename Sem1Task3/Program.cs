//=========================================================
// # 3 Напишите программу, которая будет
// выдавать название дня недели по заданному номеру
//=========================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("Такого дня нет");

    }
    else
    {
        Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    }
}

