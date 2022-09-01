Console.Write("Введите A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("A - большее число, B - меньшее число");
}
else

{
    Console.WriteLine("A - меньшее число, B - большее число");
}