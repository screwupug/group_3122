//=======================================================================================
// # 69 Задайте значения A и B. Возведите A в B через рекурсию
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

// Возведение в степень рекурсия 
int RecPow(int a, int b)
{
    if (b == 1) return a;
    return a * RecPow(a, b - 1);
}

int a = ReadData("Введите число: ");
int b = ReadData("Введите степень: ");
int pow = RecPow(a, b);
PrintData($"{pow}");