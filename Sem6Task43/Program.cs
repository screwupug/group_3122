//=======================================================================================
// # 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем
//=======================================================================================

// double[] ReadData(string line)
// {
//     Console.Write(line);
//     string inputLine = Console.ReadLine() ?? "";
//     string[] stringArray = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
//     double[] array = new double[stringArray.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = double.Parse(stringArray[i]);
//     }
//     return array;
// }

// bool Test(double[] array)
// {
//     return (((array[0] == array[1]) && (array[2] == array[3])));
// }

// double[] PointFind(double[] array)
// {
//     double[] res = new double[2];
//     double x = 0, y = 0;
//     double b1 = array[0], k1 = array[1], b2 = array[2], k2 = array[3];
//     if (Test(array) == false)
//     {
//         x = (b2 - b1) / (k1 - k2);
//         y = k1 * x + b1;
//         res[0] = x;
//         res[1] = y;
//     }
//     else
//     {
//         Console.WriteLine("Прямые параллельны.");
//     }
//     return res;
// }

// void PrintArray(double[] array)
// {
//     Console.Write($"Координаты точки пересечения - [{array[0]}, ");
//     for (int i = 1; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine($"{array[array.Length - 1]}]");
// }

// double[] inputNumbers = ReadData("Введите коородинаты через запятую: ");
// PrintArray(inputNumbers);
// double[] res = PointFind(inputNumbers);
// PrintArray(res);


//=======================================================================================
// # 43* Найдите площадь треугольника образованного пересечением 3 прямых
//=======================================================================================

double[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] stringArray = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    double[] array = new double[stringArray.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = double.Parse(stringArray[i]);
    }
    return array;
}

double SqrFind(double[] array)
{
    double res = 0;
    double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0;
    double b1 = array[0], b2 = array[1], k1 = array[2], k2 = array[3],
        c1 = array[4], c2 = array[5];

    x1 = (b2 - b1) / (k1 - k2);
    y1 = k1 * x1 + b1;
    x2 = (b2 - b1) / (c1 - c2);
    y2 = c1 * x2 + b1;
    x3 = (k2 - k1) / (c1 - c2);
    y3 = c1 * x3 + k1;
    res = 0.5 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3));

    return res;
}


double[] input = ReadData("Введите координаты 3-х линий через запятую: ");
double sqr = SqrFind(input);
Console.Write($"Площадь треугольника - {sqr}");