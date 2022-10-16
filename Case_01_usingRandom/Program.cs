int randomNumber = GetRandomNumber(1, 999999);
Console.Write("Сгенерировалось число ");
Console.WriteLine(randomNumber);
int maxValue = FindMaxValue(randomNumber);
Console.Write($"Максимальная цифра числа - {maxValue}");

int FindMaxValue(int number)
{
    int max = number % 10;
    number = number / 10;
    while(number > 0)
    {
        int lastNumber = number % 10;
        if(lastNumber > max)
        {
            max = lastNumber;
        }
        number = number / 10;    
    }
    return max;
}
int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}