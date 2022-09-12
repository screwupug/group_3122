//=============================================================================
// # 24 Напишите программу, которая принимает на вход координаты число(A)
// и выдает сумму чисел от 1 до A
//=============================================================================


// Алгоритмическое решение
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

int CalculateData(int inputNumber)
{
    int result = 0;
    for (int i = 1; i <= inputNumber; i++)
    {
        result += i;
    }
    return result;
}

// void PrintData(string line)
// {
//     Console.Write(line);
// }

// int inputNumber = ReadData("Введите число: ");
// int result = CalculateData(inputNumber);
// PrintData($"Сумма всех чисел от 1 до {inputNumber} = {result}");

// Решение с ипользованием формулы Гауса - аналитическое

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int CalculateDataGauseMethod(int inputNumber)
{
    int result = ((1 + inputNumber) * inputNumber) / 2;
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int inputNumber = ReadData("Введите число: ");
DateTime d1 = DateTime.Now; // Тест скорости
int result = CalculateDataGauseMethod(inputNumber);
Console.WriteLine(DateTime.Now - d1);
PrintResult($"Сумма чисел от 1 до {inputNumber} = {result}");
DateTime d2 = DateTime.Now;
int result1 = CalculateData(inputNumber);
Console.WriteLine(DateTime.Now - d2);
PrintResult($"Сумма чисел от 1 до {inputNumber} = {result1}");
