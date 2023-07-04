// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

Console.Clear();
double[] startArray = GetArray(5);
Console.WriteLine(String.Join("|", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");

double[] GetArray(int size){
    double[] res = new double[size];
    for (int i = 0; i <size;i++){
        res[i]= Math.Round(new Random().NextDouble()*20 - 10,3);
        
    }
    return res;
}

double GetDifference(double[] array){
    double min = array[0];
    double max = array[0];
    foreach (double el in array){
        if (min>el) min = el;
        if (max<el) max = el;
    }
    return max - min;
}



// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }