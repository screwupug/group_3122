//=============================================================================
// # 19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом. 12321
//=============================================================================

// Решение основной задачи

// Метод считывания данных 
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Метод проверки на палиндром
// bool PalindromeTest(int a)
// {
//     if ((a / 10000 == a % 10) && (a / 1000 % 10 == a / 10 % 10))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// // Метод вывода результата проверки
// void PrintResult(bool res)
// {
//     if(res)
//     {
//         Console.WriteLine("Введенное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Введенное число не является палиндромом");
//     }
// }

// int inputNumber = ReadData("Введите пятизначное число: ");
// bool res = PalindromeTest(inputNumber);
// PrintResult(res);


// Решение задачи со звездочкой

// Dictionary<int, int> palindromeDict = new Dictionary<int, int>();

// // Метод генерации чисел + запись в словарь
// Dictionary<int, int> PalindromeGenerator()
// {
//     for (int i = 10000; i < 99999; i++)
//     {
//         if ((i / 10000 == i % 10) && (i / 1000 % 10 == i / 10 % 10))
//         {
//             palindromeDict.Add(i, i);
//         }
//     }
//     return palindromeDict;
// }

// // Метод считывания данных
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Метод проверки на палиндром
// bool PalindromeTest(int a)
// {
//     if (palindromeDict.ContainsKey(a))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// // Метод вывода результата
// void PrintResult(bool res)
// {
//     if (res)
//     {
//         Console.WriteLine("Введенное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Введенное число не является палиндромом");
//     }
// }

// PalindromeGenerator();
// int inputNumber = ReadData("Введите пятизначное число: ");
// bool result = PalindromeTest(inputNumber);
// PrintResult(result);

// // Проверка заполняемости словаря
// foreach (var i in palindromeDict.Keys)
// {
//     Console.WriteLine("{0}", i);
// }

// Решение для любого числа 

// Метод считывания данных
double ReadData(string line)
{
    Console.Write(line);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод проверки палиндрома
bool PalindromeTest(double a)
{
    char[] charArray = a.ToString().ToCharArray();
    Array.Reverse(charArray); // Тут просто разворачиваем массив
    double reversedArray = double.Parse(charArray);
    if(reversedArray == a) // Проверка на палиндром
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метод вывода результата
void PrintResult(bool res)
{
    if(res)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}

double inputNumber = ReadData("Введите число: ");
bool res = PalindromeTest(inputNumber);
PrintResult(res);








