//=============================================================================
// # 25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//=============================================================================

// Обычное решение с парсингом строки
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

// double Pow(int[] array)
// {
//     double result = Math.Pow(array[0], array[1]);
//     return result;
// }

// void PrintData(string line)
// {
//     Console.WriteLine(line);
// }

// int[] inputNumbers = ReadData("Введите 2 числа через запятую: ");
// double result = Pow(inputNumbers);
// PrintData($"Число {inputNumbers[0]} в степени {inputNumbers[1]} = {result}");


//=============================================================================
// # 25* Написать калькулятор с операциями +, -, /, * и возведение в степень 
//=============================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string ReadMathOperator(string line)
{
    Console.Write(line);
    string mathOperator = Console.ReadLine() ?? "null";
    return mathOperator;
}

double CalculateData(double a, double b, string c)
{
    string mathOperator = c;
    double result = 0;

    switch (mathOperator)
    {
        case "+":
            result = a + b;
            break;
        case "-":
            result = a - b;
            break;
        case "*":
            result = a * b;
            break;
        case "/":
            result = a / b;
            break;
        case "^":
            result = Math.Pow(a, b);
            break;
        default:
            result = 0;
            break;    
    }
    return result;
}

void Printdata(string line)
{
    Console.WriteLine(line);
}

int a = ReadData("Введите число 1: ");
string mathOperator = ReadMathOperator("Введите мат. знак(+, -, *, /, ^): ");
int b = ReadData("Введите число 2: ");
double result = CalculateData(a, b, mathOperator);
Printdata($"Результат: {Math.Round(result, 2)}");

