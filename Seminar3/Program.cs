/*
int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuart(2,4);

if (result == -1)
    Console.WriteLine("Данная точка расположена на осях");
    else Console.WriteLine($"Точка находится в {result} четверти");
*/

/*
void QuadN (int N)
{
    int count = 0;
    int quad = 0;

    while (count <= N)
    {
        quad = count*count;
        count++;
        Console.WriteLine(quad);
    }
}

int N;
Console.Write("Input integer number: ");
N = Convert.ToInt32(Console.ReadLine());

QuadN(N);
*/

/*
double FindLenght(double xA, double yA, double Xb, double yB)
{
    return Math.Sqrt((xB - xA)*(xB - xA) + Math.Pow((yB-yA),2));
}
*/