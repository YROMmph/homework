// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = Prompt("Введите кол-во строк m: ");
int colums = Prompt("Введите кол-во столбцов n: ");
double[,] array = GetArray(rows,colums);

int Prompt(string message){
    Console.WriteLine(message);
    int number=int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray(int m, int n){
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j=0; j<n;j++)
        {
            result[i,j]= Math.Round(new Random().NextDouble()*20 - 10,1);
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
    return result;
}