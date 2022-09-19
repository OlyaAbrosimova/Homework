//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа : ");
int m = 5;
int[] numbers = new int [m];
NumArray(numbers);
PosNum(numbers);
System.Console.WriteLine("[{0}]", string.Join(",", PosNum(numbers)));

void NumArray (int[] numbers)
{
    for (int i = 0; i < numbers.Length; ++i)
    numbers[i] = int.Parse(Console.ReadLine());
}



int PosNum(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

