// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.





bool IsCheckNumber()
{
    Console.Write("Enter the first number => ");
    int numberFirst = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number => ");
    int numberSecond = Convert.ToInt32(Console.ReadLine());
    int sqr = 2;
    if (Math.Pow(numberFirst, sqr) == numberSecond || numberSecond * numberSecond == numberFirst) return true;
    return false;


}

bool result = IsCheckNumber();
Console.WriteLine(result);