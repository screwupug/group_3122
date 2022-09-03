//=============================================================================
// # 11 Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
//=============================================================================

System.Random randomGenerator = new System.Random();
int number = randomGenerator.Next(100, 1000);
Console.WriteLine($"Сгенерированное число = {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine(result);
// Console.WriteLine($"{firstDigit}{thirdDigit}");