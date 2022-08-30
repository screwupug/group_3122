//=========================================================
// # 2 Напишите программу, которая принимает два числа и
// выдает наибольшее из этих чисел.
//=========================================================

string? inputlineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputlineA != null && inputLineB != null)
{
    int firstNumber = int.Parse(inputlineA);
    int secondNumber = int.Parse(inputLineB);

    if (firstNumber > secondNumber)
    {
        Console.Write(firstNumber + " > " + secondNumber);
    }
    else
    {
        Console.Write(secondNumber + " > " + firstNumber);
    }
}