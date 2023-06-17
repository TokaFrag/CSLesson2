// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
int firstNumber = number / 10;
int secondNumber = number % 10;

int answer = firstNumber > secondNumber ? firstNumber : secondNumber;

Console.WriteLine($"Our random number is => {number}");
Console.WriteLine($"First number is => {firstNumber}");
Console.WriteLine($"Second number is => {secondNumber}");


Console.WriteLine($"Bigger number if {answer} ");


