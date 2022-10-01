//=======================================================================================
// # 64 Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N. Выполнить с помощью рекурсии.
//=======================================================================


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

//Метод рекурсии
string LineGenRec(int numberN)
{
    // Точка остановки
    if(numberN == 0) return "";

    string outLine = LineGenRec(numberN - 1) + " " + numberN;
    return outLine;
}

int numN = ReadData("Введите число: ");
PrintData(LineGenRec(numN));