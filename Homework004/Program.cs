Console.WriteLine("Input integer number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int toDegree (int B, int A, int result)
{
    int count = 1;
        while (count < B)
    {
        result = result * A;
        count++;
    }
return result;
}
int result = A;
result = toDegree(B, A, result);
Console.WriteLine(A + " to degree " + B + " = " + result);

/*
int size = 8;
int[] array = new int [size];

for (int i= 0; i < size; i++)
{
    array[i] = new Random().Next(0,100);
}

for (int i=0; i<size; i++)
{
    Console.Write(array[i]+ " ");
}
*/