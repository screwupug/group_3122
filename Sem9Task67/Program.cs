//=======================================================================================
// # 65 Задайте значение N. Напишите программу, будет возвращать сумму его чисел
//=======================================================================================


// Метод чтения данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода данных
void PrintData(string line)
{
    Console.WriteLine(line);
}

int RecSumDigit(int numberN)
{
    if(numberN == 0) return 0;
    return numberN % 10 + RecSumDigit(numberN / 10);
}

int number = ReadData("Введите число: ");
int sum = RecSumDigit(number);
PrintData($"{sum}");