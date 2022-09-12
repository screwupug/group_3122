//=============================================================================
// # 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
//в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки
//=============================================================================

// Обычное решение + решение со звездочкой
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] ReadDataAlternative(string line)
{
    Console.Write(line);
    string inputString = Console.ReadLine() ?? "";
    char[] unnecessChars = {',', '(', ')'};
    string[] digits = inputString.Split(unnecessChars);
    int[] numbers = new int[digits.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(digits[i]);
    }
    return numbers;
}

int CalculateData(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + (number % 10);
        number = number / 10;
    }
    return result;
}

int CalculateDataAlternative(int[] number)
{
    int result = 0;
    for(int i = 0; i < number.Length; i++)
    {
        result = result + number[i];
    }
    return result;
}

void PrintData(string line)
{
    Console.WriteLine(line);
}

int inputNumber = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int res = CalculateData(inputNumber);
Console.WriteLine(DateTime.Now - d1);
PrintData($"Результат - {res}");

// Второй метод быстрее, тк меньше вычислений
int[] inputNumberN = ReadDataAlternative("Введите число: ");
DateTime d2 = DateTime.Now;
int resN = CalculateDataAlternative(inputNumberN);
Console.WriteLine(DateTime.Now - d2);
PrintData($"Результат - {res}");