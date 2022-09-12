//=============================================================================
// # 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их 
// на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 
//=============================================================================

// Обычное решение
// int[] ArrayGenerator(int arrayLength, int start, int stop)
// {
//     Random rdn = new Random();
//     int[] array = new int[arrayLength];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = rdn.Next(start, stop);
//     }
//     return array;
// }

// void PrintData(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
// }

// int[] array = ArrayGenerator(8, 1, 8);
// PrintData(array);

// Решение со звездочкой

// int[] ReadData(string line)
// {
//     Console.Write(line);
//     string inputString = Console.ReadLine() ?? "";
//     char[] unnecessChars = {',', '(', ')'};
//     string[] digits = inputString.Split(unnecessChars);
//     int[] numbers = new int[digits.Length];
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = int.Parse(digits[i]);
//     }
//     return numbers;
// }

// int[] ArrayGeneratorAlt(int[] array)
// {
//     Random rdn = new Random();
//     int start = array[1];
//     int stop = array[2];
//     int[] newArray = new int[array[0]];
//     for(int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = rdn.Next(start, stop);
//     }
//     return newArray;
// }

// void PrintData(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
// }

// int[] inputNumbers = ReadData("Введите длину массива и диапазон чисел(мин, макс) через запятую: ");
// PrintData(ArrayGeneratorAlt(inputNumbers));

//=============================================================================
// # 30 Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал 
//=============================================================================

string[] ReadData(string line)
{
    Console.Write(line);
    string inputString = Console.ReadLine() ?? "";
    char[] unnecessChars = {',', '(', ')'};
    string[] names = inputString.Split(unnecessChars);
    return names;
}

string NameChoice(string[] array)
{
    Random rdn = new Random();
    string chosenName = array[rdn.Next(0, array.Length)];
    return chosenName;
}

void PrintData(string line)
{
    Console.WriteLine($"Выбранное имя - {line}");
}

string[] inputString = ReadData("Введите несколько имен через запятую: ");
string chosenName = NameChoice(inputString);
PrintData(chosenName);