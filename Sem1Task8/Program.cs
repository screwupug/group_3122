//=========================================================
// # 8 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//=========================================================

Console.Write("Введите число: "); // Создаем строку ввода
string? inputlineN = Console.ReadLine(); // Инициализируем сканер
int startNumber = 2; // Переменна, с кот начинается отчет

if (inputlineN != null) // Проверяем, что строка не пустая 
{
    int inputnumberN = int.Parse(inputlineN); // Парсим строку в инт

    do // Создаем цикл 
    {
        bool result = startNumber % 2 == 0; // Создаем переменную boolean с условием делится ли число на 2 без остатка
        if (result == true)
        {
            Console.Write(startNumber + ", "); // Если число делится - выводим в консоль
        }
        startNumber += 2; // прибавляем единицу к числу
    } while (startNumber <= inputnumberN - 2); // Условие завершения цикла 
    if (startNumber % 2 == 0)
    {
        Console.WriteLine(startNumber);
    }

}
