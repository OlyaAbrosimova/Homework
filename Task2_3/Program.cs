//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да


Console.Write("Введите число: ");
int numberday = Convert.ToInt32(Console.ReadLine());
bool day(int numberday)
{
    return (numberday == 6 || numberday == 7);
}
if (day(numberday) == true)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");    
}