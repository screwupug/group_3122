//=======================================================================================
// # 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//=======================================================================

// Получаем данные из консоли
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

// Генерируем трехмерный массив
int[,,] Array3DGenerator(int[] rowsColumns)
{
    int[,,] array3D = new int[rowsColumns[0], rowsColumns[1], rowsColumns[2]];
    Random rnd = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = rnd.Next(0, 10 + 1);
            }
        }
    }
    return array3D;
}

// Метод печати массива
void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}

// Метод печати чисел и индексов
void Print3DArrayNums(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} -> ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[] rowsColumns = ReadData("Введите кол-во строк и столбцов трехмерного массива: ");
int[,,] array3D = Array3DGenerator(rowsColumns);
Print3DArray(array3D);
Console.WriteLine();
Print3DArrayNums(array3D);