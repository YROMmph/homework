// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

class Program
{
    static int SumOfNaturals(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + SumOfNaturals(m+1, n);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (m > n)
        {
            Console.WriteLine("Значение M должно быть меньше или равно значению N");
        }
        else
        {
            Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, SumOfNaturals(m, n));
        }
    }
}

