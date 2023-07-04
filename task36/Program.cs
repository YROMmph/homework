// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int size = Prompt("Введите размерность массива: ");
int[] array = GetArray(size);
PrintArray(array);
int sum = 0;
int Prompt(string message){
    Console.Write(message);
    int number= int.Parse(Console.ReadLine());
    return number;
}

int [] GetArray(int size){
    int[] result = new int [size];
    for (int i=0; i<result.Length;i++){
        result[i]= new Random().Next(-101,101);
    }
    return result;
}
void PrintArray(int[] arr){
    for(int i = 0; i<arr.Length;i++){
        Console.Write($"{arr[i]} ");
        Console.Write(" ");
    }
}

for(int i = 0; i < array.Length;i++){
    if(i%2!=0)
    sum += array[i];
}

Console.Write($"Суамм элементов в массиве стоящих на нечетных позициях = {sum} ");


