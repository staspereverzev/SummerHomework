﻿/*
int num1, num2, quad;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(num1 == quad)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/

int num, current;

Console.Write("Input first integer number: ");
num = Convert.ToInt32(Console.ReadLine());

current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; //current=current + 1;
}




