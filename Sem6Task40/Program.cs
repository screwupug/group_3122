//=======================================================================================
// # 40 Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины
//=======================================================================================

int[] ReadData(string line)
{
    Console.Write(line);
    string inputString = Console.ReadLine() ?? "";
    string[] array = inputString.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] numbersArray = new int[array.Length];
    for(int i = 0; i < numbersArray.Length; i++)
    {
        numbersArray[i] = int.Parse(array[i]);
    }
    return numbersArray;
}

bool TrglTest(int[] numbersArray)
{
    bool res = false;
    if((numbersArray[0] + numbersArray[1] > numbersArray[2]) 
        && (numbersArray[1] + numbersArray[2] > numbersArray[0]) 
            && (numbersArray[0] + numbersArray[2] > numbersArray[1]))
            {
                res = true;
            }
    return res;
}

void PrintData(bool res, int[] numbersArray)
{
    if(res)
    {
        Console.WriteLine($"Треугольник с такими сторонами {numbersArray[0]}, {numbersArray[1]}, {numbersArray[2]} может существовать");
    }
    else
    {
        Console.WriteLine($"Треугольник с такими сторонами {numbersArray[0]}, {numbersArray[1]}, {numbersArray[2]} не может существовать");
    }
}

int[] numbers = ReadData("Введите три стороны треугольника через запятую: ");
bool res = TrglTest(numbers);
PrintData(res, numbers);