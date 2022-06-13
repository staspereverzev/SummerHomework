/*int SecondDigit (int N)
{
    N = N / 10;
    N = N % 10;
    Console.WriteLine($"Second digit = " + N);

    return N;
}

Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99 && N < 1000)
{
        int result = SecondDigit(N);
}
else
{
    Console.WriteLine("Wrong number");
}
*/

/*
int ThirdDigit (int N)
{
    while (N > 999)
    {
    N = N / 10;
    }
    N = N % 10;
    Console.WriteLine($"ThirdDigit = " + N);

    return N;
}

Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99)
{
    int result = ThirdDigit(N);
}
else
{
    Console.WriteLine("No ThirdDigit");
}
*/

int Days (int N)
{
    if (N > 0 && N < 8)
    {
        if (N < 6)
        {
            Console.WriteLine("Рабочий день");
        }   
        else
        {
            Console.WriteLine("Выходной");
        }
    }
    else
    {
        Console.WriteLine("Не день недели");
    }

    return N;
}

Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = Days (N);



