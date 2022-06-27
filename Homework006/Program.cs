
/*
Console.WriteLine("Введите колличество цифр");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int countMax = 0;
int countMin = 0;

void chisla (int countMax, int countMin, int count)
{
    while (count < M) 
    {
        Console.WriteLine("Enter number");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num > 0)
        {
            countMax++;
        }
        if (num < 0)
        {
            countMin++;
        }

        count++;
    }

Console.WriteLine("Положительных: " + countMax);
Console.WriteLine("Отрицательных: " + countMin);
}

chisla (countMax, countMin, count);
*/







string ar = string.Empty;
Console.WriteLine("enter");
ar = Console.ReadLine();
char [] ar1 = ar.ToCharArray();
char [] ar2 = new char [ar1.Length];

void SaveArr (char [] ar1, char [] ar2)
{
for (int i = 0; i < ar1.Length; i++)
{
    ar2[i] = ar1[i];
}
for (int i = 0; i < ar1.Length; i++)
{
    Console.Write(ar2[i]);
}
}

SaveArr(ar1, ar2);
Console.WriteLine();


