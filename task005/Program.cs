/*
    Напишите программу, которая принимает на вход два числа и проверяет, 
    является ли одно число квадратом другого. 
    5, 25 -> да 
    -4, 16 -> да 
    25, 5 -> да 
    8,9 -> нет
*/

Console.Clear();

int GetNumberSquare(int number1, int number2)
{
    if (number1 * number1 == number2 || number2 * number2 == number1)
    {
        return 1;
    }
    return 0;
}

void PrintResult(int result, int number1, int number2)
{
    int num1, num2;
    if (number1 < number2)
    {
        num1 = number2;
        num2 = number1;
    }
    else
    {
        num1 = number1;
        num2 = number2;
    }
    if (result == 1)
    {
        Console.WriteLine($"Число {num1} является квадратом {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не является квадратом {num2}");
    }
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = GetNumberSquare(number1, number2);

PrintResult(result, number1, number2);
