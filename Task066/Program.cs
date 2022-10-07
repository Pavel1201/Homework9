
Console.WriteLine("Введите M и N");

int start = int.Parse(Console.ReadLine()!);
int end = int.Parse(Console.ReadLine()!);

void FindSum(int start, int end, int sum)
{   
    if (start > end)
    {
        Console.WriteLine($"Сумма чисел от M до N = {sum}");
        return;
    }

    sum = sum + start;
    start++;
    FindSum(start, end, sum);
}

FindSum(start,end,0);