//=======================================================================================
// # 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
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

// Метод подсчета(рекурсия)
int RecSumDigit(int numM, int numN)
{
    if (numM == numN) return numN;
    return numM + RecSumDigit(numM + 1, numN);
}


int m = ReadData("Введите первое число: ");
int n = ReadData("Введите второе число: ");
int res = RecSumDigit(m, n);
PrintData($"{res}");