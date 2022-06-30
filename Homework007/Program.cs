// Первая задача
/*
double[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    double[,] newMatrix= new double [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j=0; j < b; j++)
        {
            newMatrix[i,j] = new Random().NextDouble() * 100;
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }

    return newMatrix;

}

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomTwoDemArray(a, b,1,10);
*/

// Вторая задача

/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix= new int [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j=0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max +1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }

    return newMatrix;

}

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = CreateRandomTwoDemArray(a, b, 1, 10);

Console.WriteLine();

Console.WriteLine("Введите позицию элемента (строка)");
int aX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента (столбец)");
int bX = Convert.ToInt32(Console.ReadLine());

if (aX > a || bX > b)
{
    Console.WriteLine("Такого элемента нету");
}
else
{
    Console.WriteLine("Значение элемента = " + array[aX,bX]);
}
*/

// Третья задача

int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix= new int [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j=0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max +1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }

    return newMatrix;
}

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = CreateRandomTwoDemArray(a, b, 1, 10);

double sum = 0;

Console.WriteLine();

void Avarage(int[,] array)
{
for (int j = 0; j <array.GetLength(1); j++)
{
    sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = array[i,j] + sum; 
    }
    Console.Write(sum/a + " ");
}
}
Avarage(array);
