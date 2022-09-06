//=============================================================================
// # 20 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Расстояное - сумма квадратов катетов AB2 = (y1 - y2)2 + (x1 - x2)2
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

double CalculateData(int x1, int x2, int y1, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x1: ");
int x2 = ReadData("Введите x2: ");
int y1 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y2: ");
double res = CalculateData(x1, y1, x2, y2);

PrintResult($"{Math.Round(res, 2)}");