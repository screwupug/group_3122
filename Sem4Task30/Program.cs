//=============================================================================
// # 30 Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
//=============================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[] MassiveGenerator(int number)
{
    Random rdn = new Random();
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
{
    array[i] = rdn.Next(0, 2);
    
}
return array;
}

void PrintData(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
}

int inputNumber = ReadData("Введите длину массива: ");
int[] array = MassiveGenerator(inputNumber);
PrintData(array);

