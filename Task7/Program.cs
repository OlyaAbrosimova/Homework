//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m=3;
int n=4;
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);


void FillArray(double[,] array)              // Заполняет двухмерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 10))/10;
        }
    }
}
void PrintArray(double[,] array)                  //// Выводит полученный массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
          System.Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] array = new int[,]{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

System.Console.Write("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
CheckArray(array);

void CheckArray(int[,] array)
{
    if (n > array.GetLength(0) || m > array.GetLength(1))
    System.Console.WriteLine("такого числа нет в массиве");
    else
    Console.WriteLine($"{array[n-1,m-1]}");
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = new int[,]{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
for (int j = 0; j < array.GetLength(1); j++)
{
    int count = array.GetLength(0);
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = (result + array[i, j]);
    }
    result = result / count;
    Console.Write(result + "; ");
}
Console.WriteLine();


