/*
    Напишите программу, которая выводит случайное трёхзначное 
    число и удаляет вторую цифру этого числа. 
    456 -> 46 
    782 -> 72 
    918 -> 98
*/  

Console.Clear();

int GetRandomNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

string TransformNumber(int number)
{
    int number1 = number / 100;
    int number2 = number % 10;

    string result = Convert.ToString(number1) + Convert.ToString(number2);
    return result;
}

int number = GetRandomNumber();
string result = TransformNumber(number);

 Console.WriteLine($"{number} -> {result}");
