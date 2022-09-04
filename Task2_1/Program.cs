 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

System.Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int c = b%10;
System.Console.WriteLine(c);

