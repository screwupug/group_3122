//=======================================================================================
// # 62 Напишите программу, которая заполнит спирально массив 4 на 4.
//=======================================================================

// int[,] Array2DGenerator()
// {
//     int[,] array2D = new int[4, 4];
//     Random rnd = new Random();
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = rnd.Next(1, 10 + 1);
//         }
//     }
//     return array2D;
// }

// // Метод печати массива
// void Print2DArray(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             Console.Write($"{array2D[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array2D = Array2DGenerator();
// Print2DArray(array2D);

int[,] array2D = new int[4,4]; 

for(int i = 0; i < array2D.GetLength(0) / array2D.GetLength(0); i++)
{
    for(int j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[i, j] = 1;
    }
}

for(int i = 0; i < array2D.GetLength(0); i++)
{
    for(int j = 0; j < array2D.GetLength(1); j++)
    {
        Console.Write($"{array2D[i, j]} ");
    }
    Console.WriteLine();
}