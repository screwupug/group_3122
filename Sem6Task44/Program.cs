//=======================================================================================
// # 44 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.
// Fn = Fn-1 + Fn-2
//=======================================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

bool Test(int number)
{
    return (number > 2);
}

string FibNum(int number)
{
    // 7 = 0, 1, 1, 2, 3, 5, 8
    string res = string.Empty;
    int first = 0;
    int last = 1;
    int buf = 0;
    if (Test(number))
    {
        res = "01";
        for (int i = 2; i < number; i++)
        {
            buf = first + last;
            first = last;
            last = buf;
            res += buf;
        }
    }
    else
    {
        res = "01";
    }

    return res;

}

int number = ReadData("Введите число: ");
string res = FibNum(number);
Console.Write(res);