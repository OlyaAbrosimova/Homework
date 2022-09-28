// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
MinSumRows(array);
System.Console.WriteLine(MinSumRows(array));
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int  MinSumRows(int[,] array)
{
    int minIndex = 0;
    int sumRow = 0;
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        sumRow = 0; 
        for (int j = 0; j < array.GetLength(1); j++)
        {
             sumRow += array[i, j];
        }
            if (i == 0)
            minSumRow = sumRow;
            else
            {
                if(minSumRow > sumRow)
                {
                    sumRow = minSumRow;
                    minIndex = i;
                    
                }    
            }
    }
    return minIndex;
}





// Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i -й строки и j -го столбца, равен сумме произведений элементов i -й строки матрицы А на соответствующие (по порядку) элементы j -го столбца матрицы В. Из этого определения следует формула элемента матрицы C: Произведение матрицы А на матрицу В обозначается АВ.

// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMartrix = {{2,4},{3,2}};
int[,] secondMartrix = {{3,4},{3,3}};
int[,] resultMatrix = new int[2,2];

WriteArray(firstMartrix);
WriteArray(secondMartrix);
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
WriteArray(resultMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}





// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )


int[,] array = new int [5,5];
int curElement = 0;
FillArray(array);
ArrayToConsole(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GetNewValue(array,curElement);
            curElement++;
        }
    }
}


int GetNewValue(int[,] array, int curElement )
{
    Random rnd = new Random();
    int value = rnd.Next(10,99);
    while (Contains(array, value, curElement))
    {
        value = rnd.Next(10,99);
    }
    return value;
}

bool Contains(int[,] array, int value, int curElement)
{
    int cur = 0;
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            if (array[i,j]== value)
            return true;
            if (cur == curElement)
            return false;
        }
    }
    return false;
}

void ArrayToConsole (int[,] array)
{
    int[] buf = new int [array.GetLength(1)];
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            buf[j] = array[i,j];
        }
    }
    System.Console.WriteLine("[{0}]", string.Join(",", (buf)));    
        
}
