/*
int FindSumofDigits(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum = sum + num % 10; // sun += n% 10; тоже самое
        num = num / 10; // num /= 10;
    }

    return sum;
}

int n = 234;
int result = FindSumofDigits(n);
Console.WriteLine($"Summa cifr v chisle {n} ravna {result}");
*/

/*
int FindSumofDigits(int N)
{
    int sum = 0;
    int count = 0;

    while(count <= N)
    {
        sum = sum + count; 
        count++; 
    }

    return sum;
}

Console.WriteLine("Enter digit");
int N = Convert.ToInt32(Console.ReadLine());

int result = FindSumofDigits(N);
Console.WriteLine($"Сумма цифр до числа {N} равна {result}");
*/
/*
int FindMultiplyfDigits(int N)
{
    int sum = 1;
    int count = 1;

    while(count <= N)
    {
        sum = sum * count; 
        count++; 
    }

    return sum;
}

Console.WriteLine("Enter digit");
int N = Convert.ToInt32(Console.ReadLine());

int result = FindMultiplyfDigits(N);
Console.WriteLine($"Произведение цифр до числа {N} равна {result}");
*/

/*
int FindDigits(int N)
{
        int count = 0;

    while(N > 0)
    {
        N = N/10; 
        count++; 
    }

    return count;
}

Console.WriteLine("Enter digit");
int N = Convert.ToInt32(Console.ReadLine());

int result = FindDigits(N);
Console.WriteLine($"{result}");
*/

int size = 8;
int[] array = new int [size];

for (int i= 0; i < size; i++)
{
    array[i] = new Random().Next(0,2);
}

for (int i=0; i<size; i++)
{
    Console.Write(array[i]+ " ");
}