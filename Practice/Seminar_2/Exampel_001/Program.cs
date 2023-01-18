/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и п
оказывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/


int GetConsoleNumber (string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine (message);

        if (int.TryParse (Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine( "Ввели не число: ");
        }

    }
    return result;
}


int GetRandomNumber (int leftBoard, int rightBoard)
{
    Random rnd = new Random();

    int result = rnd.Next(leftBoard, rightBoard + 1);

    return result;
}

int leftRange = GetConsoleNumber ("Введите число 1");
int rightRane = GetConsoleNumber ("введите число 2");
int number = GetRandomNumber(leftRange, rightRane);

Console.WriteLine ($"Рандомное число: {number} ");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}

else if (secondDigit > firstDigit)
{
    Console.WriteLine (secondDigit);
}
else
    Console.WriteLine ("числа равны");