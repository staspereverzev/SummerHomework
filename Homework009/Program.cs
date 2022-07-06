/*
// Первая задача
int SumRec (int N, int M)
{
    if (N <= M)
        return N + SumRec (N +1, M);
    else
        return 0;

}
*/
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

/*
Console.WriteLine("Введите число N");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumRec (N, M));
*/

//Вторая задача

int count = 1;
int NumbersRec (int N)
{
    if (N / 10 == 0)
        count = 1;
    else
    {
        NumbersRec (N/10);
        count++;
    }
       

return count;
}

Console.WriteLine(NumbersRec (N));