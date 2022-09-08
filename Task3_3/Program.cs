//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
int N = Prompt("Введите число ");
for(int count = 0; count <= N; count++)
{
    int result = count*count*count;
    System.Console.WriteLine(result);
}

