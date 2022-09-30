﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = 8;
System.Console.WriteLine(FillNaturalNumber(num));

string FillNaturalNumber(int num)
{
    if (num==1)
    return num.ToString();
    return num.ToString()+FillNaturalNumber(num-1);
}




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 1;
int n = 15;
System.Console.WriteLine(SumNaturalElements(m,n));
int SumNaturalElements(int m, int n)
{
    if(n==m)
    return m;
    return SumNaturalElements(m,(n-1))+n;
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;
System.Console.WriteLine(FuncAkkerman(m,n));

int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return FuncAkkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    else
        return n+1;   
}