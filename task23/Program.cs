﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Promt("Введите число: ");
int i = 1;
int Promt(string message){
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
while ( i <= number){
    Console.WriteLine(i*i*i + " ");
    i++;
}