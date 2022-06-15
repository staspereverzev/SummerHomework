void Polindrom (int N, int t)
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

