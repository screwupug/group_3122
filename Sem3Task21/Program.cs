//=============================================================================
// # 21 Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
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

double CalculateData(int x1, int x2, int x3, int y1, int y2, int y3)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(x3 - y3, 2));
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x1: ");
int x2 = ReadData("Введите x2: ");
int x3 = ReadData("Введите x3: ");
int y1 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y2: ");
int y3 = ReadData("Введите y3: ");
double res = CalculateData(x1, x2, x3, y1, y2, y3);
PrintResult($"{Math.Round(res, 2)}");

// Решение со звездочкой

// Метод считывания данных
string ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "0";
    // Вводим массив символов, кот надо убрать
    char[] unnecessChars = {',', '(', ')', ' '};
    // Убираем символы
    string[] digits = inputLine.Split(unnecessChars);
    // Переводим массив в строку без пробелов
    string newstr = String.Join("", digits);
    return newstr;
}

double CalculateData(string newstr)
{   
    // Переводим каждый элемент строки в инт
    int x1 = int.Parse(newstr.Substring(0, 1)), x2 = int.Parse(newstr.Substring(1, 1)),
            x3 = int.Parse(newstr.Substring(2, 1)), y1 = int.Parse(newstr.Substring(3, 1)), 
                y2 = int.Parse(newstr.Substring(4, 1)), y3 = int.Parse(newstr.Substring(5, 1));

    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(x3 - y3, 2));
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

string inputCoordinates = ReadData("Введите координаты 2х точек (Пример: (1,2,3) (4,5,6)): ");
double res = CalculateData(inputCoordinates);
PrintResult($"{Math.Round(res, 2)}");