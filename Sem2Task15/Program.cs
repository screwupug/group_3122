//=============================================================================
// # 15 Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//=============================================================================

// Решение 1

// string[] daysOfWeel = new string[] {"Понедельник", "Вторник", "Среда", "Четверг",
//  "Пятница", "Суббота", "Воскресенье"};
// Console.Write("Введите число: ");
// string? inputLine = Console.ReadLine();
// int inputNumber = 0;

// if(inputLine != null)
// {
//     inputNumber = int.Parse(inputLine);
//     if(inputNumber == 6 || inputNumber == 7)
//     {
//         Console.WriteLine("Это выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Это будний день");
//     }
// }

// Решение 2

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNumber = 0;

Dictionary<int, string> dic = new Dictionary<int, string>
{
    {1, "Понедельник"},
    {2, "Вторник"},
    {3, "Среда"},
    {4, "Четверг"},
    {5, "Пятница"},
    {6, "Суббота"}, 
    {7, "Воскресенье"}
};

if(inputLine != null)
{
    inputNumber = int.Parse(inputLine);
    
    if(inputNumber <= dic.Count)
    {
        if(inputNumber == 6 || inputNumber == 7)
        {
            Console.Write($"{dic[inputNumber]} - это выходной день");
        }
        else
        {
            Console.WriteLine($"{dic[inputNumber]} - это будний день");
        }
    }
    else
    {
        Console.WriteLine("В неделе 7 дней)");
    }
}