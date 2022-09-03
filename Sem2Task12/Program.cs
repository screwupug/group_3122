//=============================================================================
// # 12 Напишите программу, которая будет принимать на вход два числа и выводить
// является ли второе число кратно первому, если число некратно первому, то
// то программа выводит остаток от деления.
//=============================================================================

// void FirstVariant()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int firstNumber = int.Parse(inputLineA);
//         int secondNumber = int.Parse(inputLineB);

//         if (secondNumber % firstNumber == 0)
//         {
//             Console.WriteLine("Второе число кратно первому");
//         }
//         else
//         {
//             int b = secondNumber % firstNumber;
//             Console.WriteLine($"Второе число некратно первому. \nОстаток от деления - {b}");
//         }
//     }
// }

// Решение 2

// void SecondVariant()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int firstNumber = int.Parse(inputLineA);
//         int secondNumber = int.Parse(inputLineB);
//         bool digit = secondNumber % firstNumber == 0;
//         if (digit) // Необязательно писать == true, так как в digit уже указано условие true
//         {
//             Console.WriteLine("Второе число кратно первому");
//         }
//         else
//         {
//             Console.WriteLine($"Второе число некратно первому. \nОстаток от деления - {secondNumber % firstNumber}");
//         }

//     }
// }

// Глобальные переменные
int firstNumber = 0;
int secondNumber = 0;
bool result = false;


// Получаем два числа
void ReadData()
{

    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    firstNumber = int.Parse(inputLineA);
    secondNumber = int.Parse(inputLineB);
}

// Определяем кратность числа
void CalculateData()
{
    result = (secondNumber % firstNumber == 0);
}

// Выводим результаты вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine($"Второе число некратно первому. \nОстаток от деления - {secondNumber % firstNumber}");
    }
}

ReadData();
CalculateData();
PrintData();
