/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max +1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }

    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }

    return sum;
}

int[] myArray = CreateRandomArray (12, -9, 9);

Console.WriteLine("Sum positive =" + FindPositiveSum(myArray));
Console.WriteLine("Sum negative =" + FindNegativeSum(myArray));
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max +1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int[] newArray = CreateRandomArray (12, -9, 9);

int[] Change(int[] newArray)
{
    for (int i=0; i < newArray.Length; i++)
    {
        newArray[i]*= (-1);
    }
    return newArray;  
}

newArray = Change(newArray);
for (int i=0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }

Console.WriteLine();     

