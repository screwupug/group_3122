//=============================================================================
// # 28 Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
//=============================================================================

int ReadData(string line)
{
    Console.Write(line);
    int numberN = int.Parse(Console.ReadLine() ?? "");
    return numberN;
}

long CalculateData(int numberN)
{   
    long result = 1;
    for(int i = 1; i <= numberN; i++)
    {
        result = result * i;
    }
    return result;
}

void PrintData(string line)
{
    Console.WriteLine(line);
}

int inputNumber = ReadData("Введите число: ");
long result = CalculateData(inputNumber);
PrintData($"Результат = {result}");