/*
    Напишите программу, которая выводит случайное трёхзначное число и 
    удаляет вторую цифру этого числа. 
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

string TransformNumber(string strNumber)
{
    strNumber = strNumber.Remove(1, 1);
    return strNumber;
}

int number = GetRandomNumber();
string strNumber = Convert.ToString(number);
string transformNumber = TransformNumber(strNumber);
Console.WriteLine($"{number} -> {transformNumber}");





