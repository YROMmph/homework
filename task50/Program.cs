// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

int rows = Prompt("Введите индекс строки m: ");
int colums = Prompt("Введите индекс столбца n: ");
int[,] result = new int[6,7];
array(result);
if(rows < result.GetLength(0) && colums <result.GetLength(1)) Console.WriteLine($"{result[rows,colums]} - элемент находящийся в заданной позиции");
else  Console.WriteLine($"[{rows};{colums}] -> Такого числа в массиве нет");
int Prompt(string message){
    Console.WriteLine(message);
    int number=int.Parse(Console.ReadLine());
    return number;
}

void array(int[,] array){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            result[i,j]= new Random().Next(0,10);
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
}
