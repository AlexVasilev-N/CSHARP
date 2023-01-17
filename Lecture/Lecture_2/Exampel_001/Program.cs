// Поиск индекса по значению


int [] array = {1,3,5,6,7,8,9,4,55,33,};

int n = array.Length;
int find = 33;

int index = 0;

while (index < n)
{
    if (array [index] ==find)
    {
        Console.WriteLine(index);
    }
    index++;
}