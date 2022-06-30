/*
int[,] CreateTwoDemArray(int m, int n, int min, int max)
{
    int [,] array = new int [m,n];
    
    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++ )
            array[i,j] = new Random().Next(min, max +1);

    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            
            Console.WriteLine();
    }
}

int [,]ChangeLines (int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for (int j=0; j<array.GetLength(1); j++)
    {
        temp = array[strIndex1,j];
        array[strIndex1,j] = array[strIndex2, j];
        array[strIndex2,j] = temp; 
    }

return array;
}

int[,] myArray = CreateTwoDemArray(4,5,1,9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 2, 1);
Console.WriteLine();
ShowArray(myArray);
*/

int[,] CreateTwoDemArray(int m, int n, int min, int max)
{
    int [,] array = new int [m,n];
    
    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++ )
            array[i,j] = new Random().Next(min, max +1);

    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            
            Console.WriteLine();
    }
}

/*int[,] ChangeRowsColumns(int[,] array)
{
    for (int i=0; i < array.GetLength(0) - 1; i++)
    {
        for (int j=i+1; j<array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }

return array;
}

int [,] myArray = CreateTwoDemArray(4,4,1,9);
ShowArray(myArray);
Console.WriteLine();
myArray = ChangeRowsColumns(myArray);
Console.WriteLine();
ShowArray(myArray);
*/

int [,] DeleteRowColumn (int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow,minColumn];
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=i+1; j<array.GetLength(1); j++)
        {
            if(array[i,j]<min)
            {
            min = array[i,j];
            minRow = i;
            minColumn = j;
            }
        }
    }
    for (int i=0; i < array.GetLength(0); i++)
        array[i,minColumn] = 0;
    
    for (int j=0; j<array.GetLength(1); j++)
        array[minRow,j] = 0;
    return array;
}

int [,] myArray = CreateTwoDemArray(4,6,1,9);
ShowArray(myArray);
Console.WriteLine();
myArray = DeleteRowColumn(myArray);
Console.WriteLine();
ShowArray(myArray);