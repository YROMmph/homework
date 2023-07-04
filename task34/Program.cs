// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = Prompt("Введите размерность массива: ");
int[] array = GetArray(size);
PrintArray(array);

int Prompt(string message){
    Console.Write(message);
    int number= int.Parse(Console.ReadLine());
    return number;
}

int [] GetArray(int size){
    int[] result = new int [size];
    for (int i=0; i<result.Length;i++){
        result[i]= new Random().Next(99,1000);
    }
    return result;
}
void PrintArray(int[] arr){
    for(int i = 0; i<arr.Length;i++){
        Console.Write($"{arr[i]} ");
        Console.Write(" ");
    }
}
int count = 0;
foreach(int el in array){
    if((el%2) == 0) count +=1;
}
Console.Write($"Кол-во четных чисел в массиве = {count} ");





// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }