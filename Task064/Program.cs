Console.WriteLine("Введите N");

int number = int.Parse(Console.ReadLine()!);

void PrintNaturalNumbers(int maximum)
{
    if (maximum == 1)
    {
        Console.Write($"{maximum} ");



    }
    else
    {
        
        Console.Write($"{maximum}, ");
        PrintNaturalNumbers(maximum - 1);

    }

}

PrintNaturalNumbers(number);