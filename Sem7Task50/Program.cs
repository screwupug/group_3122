//=======================================================================================
// # 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//=======================================================================================

int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] numbersLine = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] numbers = new int[numbersLine.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(numbersLine[i]);
    }
    return numbers;
}

int[,] Array2DGenerator(int[] numbers)
{
    Random rdn = new Random();
    int[,] array2D = new int[numbers[0], numbers[1]];
    for (int i = 0; i < numbers[0]; i++)
    {
        for (int j = 0; j < numbers[1]; j++)
        {
            array2D[i, j] = rdn.Next(0, 10 + 1);
        }


    }
    return array2D;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }

}

int FindNumber(int[,] array, int[] coords)
{
    if (coords[0] < array.GetLength(0) && coords[1] < array.GetLength(1))
    {
        return array[coords[0], coords[1]];
    }
    else
    {
        return -1;
    }
}

void Print(int res)
{
    if (res != -1)
    {
        Console.WriteLine($"По данным координатам находится элемент {res}");
    }
    else
    {
        Console.WriteLine("В данном двумерном массиве нет элемента с такими координатами");
    }
}

// Решение с числами Фиббоначи

int[,] Array2DFibbonachiGenerator(int[] numbers)
{
    int first = 0;
    int last = 1;
    int buf = 0;
    int[,] array2D = new int[numbers[0], numbers[1]];
    for (int i = 0; i < numbers[0]; i++)
    {
        for (int j = 0; j < numbers[1]; j++)
        {
            array2D[i, j] = buf;
            buf = first + last;
            first = last;
            last = buf;

        }


    }
    return array2D;
}

ConsoleColor[] color = new ConsoleColor[] {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                            ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, 
                                ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, 
                                    ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, 
                                        ConsoleColor.Yellow};

void PrintFibbonachiNumber(int res, int[,] array)
{
    Random rnd = new Random();
    if (res != -1)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] == res)
                {
                    Console.ForegroundColor = color[rnd.Next(color.Length)];
                    Console.Write($"{array[i, j]} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                     Console.Write($"{array[i, j]} ");
                }
            }
            Console.WriteLine("");
        }
    }
    else
    {
        Console.WriteLine("В данном двумерном массиве нет элемента с такими координатами");
    }
}


int[] arrayChars = ReadData("Введите кол-во строк и стобцов массива через запятую: ");
int[,] array2D = Array2DFibbonachiGenerator(arrayChars);
Print2DArray(array2D);
int[] numberCoords = ReadData("Введите координаты элемента через запятую: ");
int res = FindNumber(array2D, numberCoords);
Console.WriteLine(res);
PrintFibbonachiNumber(res, array2D);