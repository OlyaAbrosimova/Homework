Console.Write("Введите A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;
Console.Write("max=");
Console.WriteLine(max);

