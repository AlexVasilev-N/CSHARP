 /*
 Напишите программу, которая будет принимать на вход два числа и выводить, 
 является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно

*/



string Foo(int numA, int numB)
{
    if (numA % numB == 0)
    {   
    result = "Кратны";
    }
    else
    {
    result = $"{numA % numB}";
    }
    return result;
}  

int numA = 35;
int numB = 5;

Console.WriteLine(result);


