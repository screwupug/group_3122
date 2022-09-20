//=======================================================================================
// # 42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//=======================================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string BinConvert(int number)
{
    string res = String.Empty;
    while(number > 0)
    {
        res = number % 2 + res;
        number /= 2;
    }
    return res;
}

void PrintData(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число: ");
string res = BinConvert(number);
PrintData(res);