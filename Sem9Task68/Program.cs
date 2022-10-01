//=======================================================================================
// # 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
//=======================================================================================

// Метод чтения данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод подсчета рекурсия 
int AckRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckRec(m - 1, 1);
    }
    return AckRec(m - 1, AckRec(m, n - 1));

}

// Метод вывода данных
void PrintData(string line)
{
    Console.WriteLine(line);
}

int m = ReadData("Введите первое число: ");
int n = ReadData("Введите второе число: ");
int res = AckRec(m, n);
PrintData($"{res}");