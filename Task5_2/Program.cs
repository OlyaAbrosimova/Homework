// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int size = 4;
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(",", array));
int sum = 0;
SumOdd(array);
System.Console.WriteLine("[{0}]", string.Join(",", sum));


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}
int SumOdd(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
            {
                sum=sum+array[i];
            }
    }
    return sum;
}

