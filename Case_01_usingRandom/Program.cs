int randomNumber = GetRandomNumber(1, 999999);
Console.Write("Сгенерировалось число ");
Console.WriteLine(randomNumber);
int max = randomNumber % 10;
randomNumber = randomNumber / 10;
while(randomNumber > 0)
{
    int lastNumber = randomNumber % 10;
    if(lastNumber > max)
    {
        max = lastNumber;
    }
    randomNumber = randomNumber / 10;    
}
Console.WriteLine($"максимальное цифра в сгенерированном - {max}");
int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}