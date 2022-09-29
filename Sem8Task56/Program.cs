//=======================================================================================
// # 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов. 
//=======================================================================================


// Получаем данные из строки + парсим их в массив
int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] inputNumber = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] rowsColumns = new int[inputNumber.Length];
    for (int i = 0; i < rowsColumns.Length; i++)
    {
        rowsColumns[i] = int.Parse(inputNumber[i]);
    }
    return rowsColumns;
}

// Проверка на прямоугольность массива
bool RectangleTest(int[] rowsColumns)
{
    if (rowsColumns[0] == rowsColumns[1])
    {
        return false;
    }
    else
    {
        return true;
    }
}

// Генерируем двумерный массив
int[,] Array2DGenerator(int[] rowsColumns)
{
    int[,] array2D = new int[rowsColumns[0], rowsColumns[1]];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 100 + 1);
        }
    }
    return array2D;
}

// Метод печати массива
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Находим строку с мин суммой
int FindMinRow(int[,] array2D)
{
    int sum = 0;
    int min = int.MaxValue;
    int rowIndex = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        sum = 0; // Нужно обнулять сумму, чтобы все работало
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        if (min > sum)
        {
            min = sum;
            rowIndex = i;
        }
    }
    return rowIndex;
}

// Вывод индекса + 1
void PrintData(int rowIndex)
{
    Console.WriteLine($"Номер строки с минимальной суммой чисел - {rowIndex + 1}");
}

int[] rowsColumns = ReadData("Введите кол-во строк и столбцов для прямоугольного массива через запятую: ");
bool test = RectangleTest(rowsColumns);
int[,] array2D = new int[rowsColumns[0], rowsColumns[1]];
// Проверка прямоугольный ли массив
if (test)
{
    array2D = Array2DGenerator(rowsColumns);
    Print2DArray(array2D);
}
else
{
    Console.WriteLine("Ошибка. Невозможно создать прямоугольный массив.");
}
int rowIndex = FindMinRow(array2D);
Console.WriteLine();
PrintData(rowIndex);