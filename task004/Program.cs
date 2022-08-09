/*
    Напишите программу, которая принимает на вход число и проверяет, 
    кратно ли оно одновременно 7 и 23. 
    14 -> нет 
    46 -> нет 
    161 -> да
*/

Console.Clear();

int number1 = 7;
int number2 = 23;

int MultipleNumber(int number)
{
    // int number1 = 7;
    // int number2 = 23;
    int result1 = (number % number1);
    int result2 = (number % number2);
    if (result1 == 0 && result2 == 0)
    {
        return 1;
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
    return 0;
}


void PrintResult(int result, int number)
{
    if (result == 1)
    {
        Console.WriteLine($"Число {number} кратно числу {number1} и числу {number2}");
    }
    else
    {
        Console.WriteLine($"Число {number} не кратно числу {number1} и числу {number2}");
    }
}

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = MultipleNumber(number);

PrintResult(result, number);



