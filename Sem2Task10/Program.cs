//=============================================================================
// # 10 Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// * показывает второю цифру любого числа
//=============================================================================

// // Решение 1
// Console.Write("Введите трехзначное число: ");
// string? inputLine = Console.ReadLine();

// if (inputLine != null && inputLine.Length == 3)
// {
//     int inputNumber = int.Parse(inputLine);
//     char[] charArray = inputNumber.ToString().ToCharArray();
//     Console.WriteLine($"Вторая цифра числа {inputNumber} - {charArray[1]}");
// }
// else
// {
//     Console.WriteLine("Вы ввели неправильное число");
// }

// Решение 2 со *

Console.Write("Введите любое число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    if(inputLine.Length >= 2)
    {
        int inputNumber = int.Parse(inputLine);
        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine($"Вторая цифра числа {inputNumber} - {charArray[1]}");
    }
    else
    {
        Console.WriteLine("У введенного числа нет второй цифры");
    }
}
else
{
    Console.WriteLine("Вы ввели неправильное число");
}