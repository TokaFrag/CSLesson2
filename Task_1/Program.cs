Random rand = new Random();
int number = rand.Next(100, 1000);


int GetNumber(int num)
{
    int firstNumber = num / 100;
    int secondNumber = num % 10;
    int thirdNumber = firstNumber * 10 + secondNumber;

    return thirdNumber;
}

int result = GetNumber(number);
Console.WriteLine(result);