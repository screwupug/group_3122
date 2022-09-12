//=============================================================================
// # 26 Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе
//=============================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int CalculateData(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += 1;
        number = number / 10;
    }
    return result;
}

void PrintData(string line)
{
    Console.Write(line);
}

int inputNumber = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int res = CalculateData(inputNumber);
Console.WriteLine(DateTime.Now - d1);
PrintData($"Количество цифр в числе {inputNumber} - {res}");