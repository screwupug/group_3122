//=============================================================================
// # 35 Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
//=============================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[] ArrayGenerator(int downBorder, int topBorder)
{
    Random rdn = new Random();
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(downBorder, topBorder + 1);

    }
    return array;
}

// Можно зарарнее написать спец функцию с бул для проверки условия и вложить ее в другую
bool Test(int a)
{
    return(a > 10 && a < 99);
}

int FindNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Test(array[i])) // Вкладываем функцию тест 
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[" + array[0] + ",");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

void PrintData(int result)
{
   if(result != 0)
   {
    Console.WriteLine($"В данном массиве {result} элементов, лежащих между 10 и 99");
   }
   else
   {
    Console.WriteLine($"В данном массиве {result} элементов, лежащих между 10 и 99");
   }
}

Console.WriteLine("Сейчас будет сгенерирован массив из 123-х элементов");
int downBorder = ReadData("Введите минимальное число в массиве: ");
int topBorder = ReadData("Введите максимальное число в массиве: ");
int[] array = ArrayGenerator(downBorder, topBorder);
PrintArray(array);
int result = FindNumbers(array);
PrintData(result);
