// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadInt("Введите число: ");
int L = numberlen(number);
SumNumbers(number, L);

int ReadInt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberlen(int a){
    int index = 0;
    while(a>0){
        a/=10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int L){
    int sum = 0;
    for (int i = 1; i<=L;i++){
        sum+= n%10;
        n/=10;

    }
    Console.WriteLine($"{sum} - Сумма цифр в числе") ;
}

    // if (){
    //     Console.WriteLine();
    // } else {
    //     Console.WriteLine();
    // }

