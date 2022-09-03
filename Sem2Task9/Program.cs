//=============================================================================
// # 9 Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
//=============================================================================

void MyVariant()
{
    Console.WriteLine("Метод1");
    System.Random numberGenerator = new System.Random(); // Создали переменную и выделили оперативную память
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Наибольшая цифра = {firstDigit}");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра = {secondDigit}");
    }
}

void SecondVariant()
{
    // Второй вариант вместо if
    Console.WriteLine("Метод2");
    System.Random numberGenerator = new System.Random(); // Создали переменную и выделили оперативную память
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void CharVariant()
{
    // Вариант char
    Console.WriteLine("Метод3");
    System.Random numberGenerator = new System.Random(); // Создали переменную и выделили оперативную память
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToCharArray(); // Переводим int в char и помещаем символы в массив
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

MyVariant();

SecondVariant();

CharVariant();