Console.Write("Enter the first number => ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first number => ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int answer = numberFirst % numberSecond;
if (answer == 0)
{
    Console.WriteLine($"Number {numberSecond} is a multiple of {numberFirst}");
}
else
{
    Console.WriteLine($"Remainder of the division {answer}");
}


