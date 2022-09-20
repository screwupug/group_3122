//=======================================================================================
// # 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь. 
//=======================================================================================

// int[] ReadData(string line)
// {
//     Console.Write(line);
//     string inputLine = Console.ReadLine() ?? "";
//     string[] stringArray = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
//     int[] array = new int[stringArray.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = int.Parse(stringArray[i]);
//     }
//     return array;
// }

// int PositiveNumCount(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// int[] inputNumbers = ReadData("Введите любые числа через запятую: ");
// int count = PositiveNumCount(inputNumbers);
// Console.WriteLine($"Количество чисел больше 0 в данном вводе - {count}");

//=======================================================================================
// # 41 Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает 
// сколько чисел больше 0 было введено.
//=======================================================================================

int ReadDataAlt(string line)
{
    Console.Write(line);
    int clickCount = int.Parse(Console.ReadLine() ?? "0");
    return clickCount;
}

int PositiveNumCountAlt(int clickCount)
{   
    Console.Write("Введите числа через пробел: ");
    int countClick = 0;
    int posCount = 0;
    string buffKey = string.Empty;
    while(countClick <= clickCount)
    {
        ConsoleKeyInfo inputKey = Console.ReadKey();
        switch(inputKey.Key)
        {
            // 1 10 0 3, 459 -10
            case ConsoleKey.D0:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.D1:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.D2:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.D3:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.D4:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }case ConsoleKey.D5:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }case ConsoleKey.D6:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }case ConsoleKey.D7:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }case ConsoleKey.D8:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.D9:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.OemMinus:
            {
                buffKey = buffKey + inputKey.KeyChar.ToString();
                countClick++;
                break;
            }
            case ConsoleKey.Spacebar:
            {
                if(buffKey.Contains('-') || buffKey.IndexOf('0') == 0)
                {
                    buffKey = string.Empty;
                }
                else
                {
                    buffKey = string.Empty;
                    countClick++;
                    posCount++;
                }
                break;
            }
            default:
            {
                countClick++;
                break;
            }

        }
    }
    return posCount;
}

int countAlt = ReadDataAlt("Введите кол-во нажатий (учитывайте пробелы): ");
int posCount = PositiveNumCountAlt(countAlt);
Console.WriteLine("");
Console.WriteLine($"Количество чисел больше нуля - {posCount}");