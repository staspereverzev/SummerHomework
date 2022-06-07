int num, current;

Console.Write("Input first integer number: ");
num = Convert.ToInt32(Console.ReadLine());

current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; //current=current + 1;
}