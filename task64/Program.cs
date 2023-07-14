// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введдите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(N)}");

string Range(int N)
{
    if(N==1) return "1";
    return N + ", " + Range(N-1);
}







// int Factorial(int N)
// {
//     if(N==1) return 1;
//     else return N * Factorial(N-1);
// }
// Console.WriteLine(Factorial(3));