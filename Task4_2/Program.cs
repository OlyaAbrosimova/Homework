// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

  int Sum(int number)
  {
    int counter = Convert.ToString(number).Length;
    int number1 = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
     number1 = number - number % 10;
      result = result + (number - number1);
      number = number / 10;
    }
   return result;
  }

int sum = Sum(number);
Console.WriteLine(sum);
