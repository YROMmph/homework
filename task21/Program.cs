// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int Promt(string message)
{
Console.Write(message);
int distance = int.Parse(Console.ReadLine());
return distance;
}

int x1 =  Promt ("Введите координаты точка x A: ");
int y1 =  Promt ("Введите координаты точка y A: ");
int z1 =  Promt ("Введите координаты точка z A: ");
int x2 =  Promt ("Введите координаты точка x B: ");
int y2 =  Promt ("Введите координаты точка y B: ");
int z2 =  Promt ("Введите координаты точка z B: ");

double AB = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));

Console.WriteLine(Math.Round(AB, 2));

