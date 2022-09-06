//=============================================================================
// # 22 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//=============================================================================

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

string LineNubers(int numberN)
{
    int i = 0;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i + "\t";
        i++;
    }
    outLine = outLine + numberN;
    return outLine;
}

string SquareLine(int numberN)
{
    int i = 0;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i * i + "\t";
        i++;
    }
    outLine = outLine + i * i;
    return outLine;

}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите исло N: ");
string lineTop = LineNubers(num);
string lineDown = SquareLine(num);

PrintResult(lineTop);
PrintResult(lineDown);

