/*
Напишите программу, которая выводит случайное т
рехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

*/

//генерирует случайно число в границах [leftBoard, rightBoard]

int GetRandomNumber(int leftBoard, int rightBoard)
{
Random rnd = new Random();

int result = rnd.Next(leftBoard, rightBoard + 1); //[leftBoard, rightBoard)

return result;
}


int leftRange = GetNumberFromConsole("Введите левую границу диапазона рандомного значения:");
int rightRange = GetNumberFromConsole("Введите правую границу диапазона рандомного значения:");
int number = GetRandomNumber(leftRange, rightRange);

Console.WriteLine($"Рандомное число: {number}");



int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit * 10 + thirdDigit;

Console.WriteLine(result);