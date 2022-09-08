//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int Sqrt(int n)
{
    return n * n;
}
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
    
}
int[] inputCoords(int n)
{
    int[] coord = new int[3];
    coord[0] = Prompt($"Введите x точки ");
    coord[1] = Prompt($"Введите y точки ");
    coord[2] = Prompt($"Введите z точки ");
    return coord;
}

int[] coord1 = inputCoords(1);
int[] coord2 = inputCoords(2);

double result = Math.Sqrt(Sqrt(coord2[0] - coord1[0]) + Sqrt(coord2[1] - coord1[1]) + Sqrt(coord2[2] - coord1[2]));
System.Console.WriteLine(result);

