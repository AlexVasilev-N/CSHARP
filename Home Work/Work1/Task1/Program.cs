

Console.WriteLine("Введите число:");

string numberStr = Console.ReadLine() ?? "";// fsdfdsdsf, 1223423 "fsdfdsdsf", "1223423"
int number = int.Parse(numberStr);// "323" -> 323
int result = number * number;

Console.WriteLine($"квадрат числа {number} = {result}");
Console.WriteLine("квадрат числа {number} = {result}");


