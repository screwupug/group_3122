//=============================================================================
// # 14 Напишите программу, которая будет принимать на число и проверяет
// кратно ли оно одновременно 7 и 23.
//=============================================================================


int number = 0;
bool result = false;
// Принимаем число
void ReadData()
{
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null)
    {
        number = int.Parse(inputLine);
    }
}

// Проверяем кратно ли число одновременно 7 и 23
void CalculateData()
{
    result = (number % 7 == 0 && number % 23 == 0);
}

// Выводим результат вычислений
void PrintData()
{
    if(result)
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число некратно 7 и 23");
    }
}

ReadData();
CalculateData();
PrintData();