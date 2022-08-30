//=========================================================
// # 3 Напишите программу, которая будет
// выдавать название дня недели по заданному номеру
//=========================================================

string? inputLine = Console.ReadLine();

int inputDayOfWeek = int.Parse(inputLine);

// if (inputLine != null)
// {
//     int inputDayOfWeek = int.Parse(inputLine);

//     // string[] dayOfWeek = new string[7];
//     // dayOfWeek[0] = "Понедельник";
//     // dayOfWeek[1] = "Вторник";
//     // dayOfWeek[2] = "Среда";
//     // dayOfWeek[3] = "Четверг";
//     // dayOfWeek[4] = "Пятница";
//     // dayOfWeek[5] = "Суббота";
//     // dayOfWeek[6] = "Воскресенье";

//     // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
//     // {
//     //     Console.WriteLine("Такого дня нет");

//     // }
//     // else
//     // {
//     //     Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
//     // }
// }

string outDayOfWeek = string.Empty;

switch(inputDayOfWeek)
{
    case 1: outDayOfWeek = "Понедельник"; break;
    case 2: outDayOfWeek = "Вторник"; break;
    case 3: outDayOfWeek = "Среда"; break;
    case 4: outDayOfWeek = "Четверг"; break;
    case 5: outDayOfWeek = "Пятница"; break;
    case 6: outDayOfWeek = "Суббота"; break;
    case 7: outDayOfWeek = "Воскресенье"; break;
    default: outDayOfWeek = "Такого дня нет"; break;
}
Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
// outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(DayOfWeek)Enum.GetValues