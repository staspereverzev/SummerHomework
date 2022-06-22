/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min (>= 100 and <=1000): ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max (>= 100 and <=1000): ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);

int count = 0;
int Kollicestvochetnihint(int count) 
{
    for (int i = 0; i < size; i++)
    {
        if (newArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int result = Kollicestvochetnihint(count);

Console.WriteLine("Kollicestvo chetnih =" + result);
*/

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);

int count = 0;int sumNechetPos (int count)
{
    for (int i = 0; i < size; i = i+2)
    {
        count = newArray[i] + count;
    }
return count;
}

int result = sumNechetPos (count);
Console.WriteLine("Summa nechetnih posiciy =" + result);
*/

double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() * 100;
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(size);

double min = newArray[0];
double max = newArray[0];

double findMin( double min)
{
for (int i = 0; i < size; i++)
    {
        if (newArray[i] < min)
        { 
        min = newArray[i];
        }
    }
return min;
}

double findMax( double max)
{
for (int i = 0; i < size; i++)
    {
        if (newArray[i] > max)
        { 
        max = newArray[i];
        }
    }
return max;
}
min = findMin(min);
max = findMax(max);

Console.WriteLine("min = " + min);
Console.WriteLine("max = " + max);
double result = max - min;
Console.WriteLine("max - min =" + result);

