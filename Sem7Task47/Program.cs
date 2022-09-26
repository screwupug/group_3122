//=======================================================================================
// # 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//=======================================================================================

int ReadData(string line)
{
    Console.Write(line);
    int input = int.Parse(Console.ReadLine() ?? "0");
    return input;
}

int[,] Array2DGenerator(int countRow, int countColumn)
{
    Random rdn = new Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rdn.Next(0, 10 + 1);
        }


    }
    return array2D;
}

ConsoleColor[] color = new ConsoleColor[] {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                            ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, 
                                ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, 
                                    ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, 
                                        ConsoleColor.Yellow};

void Print2DArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = color[rnd.Next(color.Length)];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }

}



int countRow = ReadData("Введите кол-во строк: ");
int countColumn = ReadData("Введите кол-во столбцов: ");
int[,] array2D = Array2DGenerator(countRow, countColumn);
Print2DArray(array2D);