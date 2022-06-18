/*void Polindrom (int N, int t)
{
    t = t % 10000;
    t = t / 10;
    if (N / 10000 == N % 10 && t / 100 == t % 10)
    {
        Console.WriteLine("Palindrom");
    }
    else
    {
        Console.WriteLine("Ne palindrom");
    }  
}

Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());
int t = N;


Polindrom (N, t);
*/

/*
void CubedN (int N)
{
    int count = 0;
    int cube = 0;

    while (count <= N)
    {
        cube = count*count*count;
        count++;
        Console.WriteLine(cube);
    }
}

int N;
Console.Write("Input integer number: ");
N = Convert.ToInt32(Console.ReadLine());

CubedN(N);
*/

double xA; double yA; double zA; double xB; double yB; double zB;

Console.Write("Введите координату X точки A: ");
xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки A: ");
yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z точки A: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z точки B: ");
zB = Convert.ToDouble(Console.ReadLine());

double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt((xB - xA)*(xB - xA) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2));
}

double result = FindLenght(xA, yA, zA, xB, yB, zB);
Console.WriteLine(result);