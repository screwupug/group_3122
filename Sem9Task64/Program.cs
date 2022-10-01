//=======================================================================================
// # 64 Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
//=======================================================================

// Получаем данные от пользователя
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


// Генерация строки через рекурсию
string LineGenRec(int numberN)
{
    // Точка остановки
    if(numberN == 0) return "";

    string outLine = numberN + " " + LineGenRec(numberN - 1);
    return outLine;
}

int number = ReadData("Введите число: ");
PrintData(LineGenRec(number));