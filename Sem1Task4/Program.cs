//=========================================================
// # 4 Напишите программу, которая принимает три числа и
// а и выдаёт максимальное из этих чисел.
//=========================================================

Console.Write("Введите первое число: "); // Создание строки для ввода
string? inputlineA = Console.ReadLine(); // Создания сканера строки
Console.Write("Введите второе число: ");
string? inputlineB = Console.ReadLine();
Console.Write("Введите третье число: ");
string? inputlineC = Console.ReadLine();

if (inputlineA != null && inputlineB != null && inputlineC != null) // Задаем условие, что строки не должны быть пустые

{
    int firstNumber = int.Parse(inputlineA); // Присваиваем переменные + парсим строку в инт
    int secondNumber = int.Parse(inputlineB);
    int thirdNumber = int.Parse(inputlineC);
    int maxNumber = 0; // Создаем переменную для хранения макс значения

    if (firstNumber > secondNumber) // Сравниваем первую пару
    {
        maxNumber = firstNumber; // Изменяем значение переменной
    }
    else
    {
        maxNumber = secondNumber; // Изменяем значение переменной
    }

    if (maxNumber > thirdNumber) // Сравнваем вторую пару(в maxNumber уже есть наибольшое число из первой пары)
    {
        Console.WriteLine("Наибольшее число: " + maxNumber); // Вывод результата в консоль
    }
    else
    {
        maxNumber = thirdNumber;
        Console.WriteLine("Наибольшее число: " + maxNumber); // Вывод результата в консоль
    }
}


// Решение 2

// if (inputlineA != null && inputlineB != null && inputlineC != null)
// {
//     int firstNumber = int.Parse(inputlineA);
//     int secondNumber = int.Parse(inputlineB);
//     int thirdNumber = int.Parse(inputlineC);
//     int[] array = new int[3]; // Создаем массив
//     array[0] = firstNumber; // Помещаем значения переменных в массив
//     array[1] = secondNumber;
//     array[2] = thirdNumber;
//     int max = array[0]; // Создаем переменную для хранения макс числа (по-дефолту первая ячейка массива)
//     int count = 0; // Задаем счетчик

//     do
//     {
//         if (array[count] > max) // Создаем цикл do while
//         {
//             max = array[count];
//         }
//         count++;
//     } while (count < array.Length);
//     Console.Write("Наибольшее число: " + max); // Вывод результата в консоль

// }