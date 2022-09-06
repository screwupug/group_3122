//=============================================================================
// # 16 Напишите программу, которая будет принимать на вход два числа и проверяет
// является ли одно число квадратом другого.
//=============================================================================


int ReadData(string line)
{   
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine()??"0");
    // Возвращаем значение
    return number;
}

// Тест на квадрат
bool SqrTest(int firstNumber, int secondNumber)
{
    if(firstNumber == secondNumber * secondNumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int firstNumber, int secondNumber)
{
    if(SqrTest(firstNumber, secondNumber))
    {
        Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}");
    }
    else
    {
        Console.WriteLine($"Число {firstNumber} не является квадратом числа {secondNumber}");
    }
}

int num1 = ReadData("Ведите первое число: ");
int num2 = ReadData("Ведите второе число: ");

PrintData(num1, num2);
PrintData(num2, num1);