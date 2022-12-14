//=========================================================
// # 6 Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
//=========================================================

Console.WriteLine("Введите число: "); // Создаем строку для ввода
string? inputline = Console.ReadLine(); // Создаем сканер строки

if (inputline != null) // Задаем условие, что строка не должна быть пустой
{
    int inputNumber = int.Parse(inputline); // Парсим строку в инт
    int result = inputNumber % 2; // Полчаем остаток от деления на 2

    if (result == 0) // Задаем условие при котором остаток = 0 - четное, остаток != 0 - нечетное
    {
        Console.WriteLine("Введенное число " + inputNumber + " является четным");
    }
    else
    {
        Console.WriteLine("Введенное число " + inputNumber + " является нечетным");

    }
}

// Решение 2

// if (inputline != null)
// {
//     int inputNumber = int.Parse(inputline);
//     bool result = inputNumber % 2 == 0; // Задаем переменную boolean и условие, что при делении числа на два остаток = 0
//     if(result == true) // Задаем условие, что условие верно
//     {
//         Console.WriteLine("Введенное число " + inputNumber + " является четным");
//     }
//     else
//     {
//         Console.WriteLine("Введенное число " + inputNumber + " является нечетным");
//     }
// }