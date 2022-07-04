/*int[,] CreateTwoDemArray(int m, int n, int min, int max)
{
    int [,] array = new int [m,n];
    
    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++ )
            array[i,j] = new Random().Next(min, max +1);

    return array;
}
*/

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            
            Console.WriteLine();
    }
}

/* 
//Первая задача
int [,] BubbleSort (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int c = j+1; c < array.GetLength(1); c++)
        {
        if (array[i,j] > array[i,c])
        {
        int temp = array[i,j];
        array[i,j] = array[i,c];
        array[i,c] = temp;
        }
        }
    }
}
return array;
}
*/

/*
//Вторая задача
void MinSumString (int [,] array)
{
int stringSum = 0;
int count = 0;
int minSum = 0;
int minString = 0;

for (int i=0; i<array.GetLength(0); i++)
{   
    for (int j=0; j<array.GetLength(1); j++)
        minSum = minSum + array[1,j];
    
}

for (int i=0; i<array.GetLength(0); i++)
{   
    for (int j=0; j<array.GetLength(1); j++)
    {
        stringSum = stringSum + array[i,j];
    }
    count++;
    if (stringSum < minSum)
        {
            minSum = stringSum;
            minString = count;
        }
    Console.Write(stringSum + " ");
    stringSum = 0;
}
Console.WriteLine();
Console.WriteLine(minString + " строка");
}
*/
/*
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,] array = CreateTwoDemArray(m,n,1,9);
ShowArray(array);
Console.WriteLine();





Console.WriteLine();
//BubbleSort(array);
//ShowArray(array);
//MinSumString(array);
*/

//Третья задача

int [,] array = new int[4,4];

void SpiralFiling(int [,] array)
{


for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 1; j < array.GetLength(1); j++)
    {
        array[0,0] = 1;
        array[i,j] = array[i,j-1] +1;
        array[j,i] = array[j-1,i] +1;
    }

for (int i = array.GetLength(0)-1; i > 0; i--)
    for (int j = array.GetLength(1)-1; j > 0; j--)
            array[i,j-1] = array[i,j] +1;
          
for (int i = array.GetLength(0)-1; i > 1; i--)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i-1,0] = array[i,0]+1;

for (int i = 1; i < array.GetLength(0)-1; i++)
    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        array[i,j] = array[i,j-1] +1;
        
    }

for (int i = 1; i < array.GetLength(0)-2; i++)
    for (int j = 1; j < array.GetLength(1)-1; j++)
        array[i+1,j]=array[i,j] +1;

for (int i = array.GetLength(0)-2; i > 1; i--)
    for (int j = array.GetLength(1)-2; j > 1; j--)
            array[i,j-1] = array[i,j] +1;
}

SpiralFiling(array);
ShowArray(array);