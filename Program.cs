// See https://aka.ms/new-console-template for more information

int randomNumber = GetRandomNumber(10, 100);

Console.WriteLine(randomNumber);

int maxValue = FindMaxValue(randomNumber);

Console.WriteLine(maxValue);

int FindMaxValue(int number)
{
    int max = number % 10; // 151  % 10 ->  1
    number = number / 10; // 151 / 10 -> 15.1 -> 15 == number

    while (number > 0)// 15 > 0
    {
        int lastNumber = number % 10; // 15 % 10 -> 5
        if (lastNumber > max) // 5 > 1
        {
            max = lastNumber; // max == 5
        }
        number = number / 10;//  15 / 10 -> 1.5 -> 1
    }

    return max;
}

int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}


