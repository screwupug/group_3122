//=============================================================================
// # 13 Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// * показывает третью цифру любого числа
//=============================================================================

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNumber = 0;

if(inputLine != null) 
{
    inputNumber = int.Parse(inputLine); 
}

char[] charArray = inputNumber.ToString().ToCharArray();
if(charArray.Length >= 3)
{
    Console.WriteLine($"Третья цифра числа {inputNumber} = {charArray[2]}");
}
else
{
    Console.WriteLine("В введном числе нет третьей цифры");
}