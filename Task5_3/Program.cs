// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] array = new double [4];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(",", array));
double min, max;
FindMaxMin(array, out min, out max);
System.Console.WriteLine($"Max = {max}; Min = {min} ");
double diff = max - min;
System.Console.WriteLine($"Разность = {diff}"); 

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}
void FindMaxMin(double[] array, out double min, out double max)
{
    max = array[0];
    min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) 
            max = array[i];
        if (array[i] < min) 
            min = array[i];

    }
}    
