//=========================================================
// # 8 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//=========================================================

Console.Write("Введите число: "); // Создаем строку ввода
string? inputlineN = Console.ReadLine(); // Инициализируем сканер
int startNumber = 1; // Переменна, с кот начинается отчет

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
        startNumber++; // прибавляем единицу к числу
    } while (startNumber < inputnumberN); // Условие завершения цикла 
    Console.WriteLine(inputnumberN);

}
