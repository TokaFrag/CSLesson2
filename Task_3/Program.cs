﻿// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.




bool IsCheckNumber()
{
    Console.Write("Enter the number => ");
    int number = Convert.ToInt32(Console.ReadLine());
    if ((number % 7) == 0 && (number % 23) == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}

bool result = IsCheckNumber();
Console.WriteLine(result);