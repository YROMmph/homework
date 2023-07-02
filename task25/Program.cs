// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = ReadInt("Введите число А: ");
int B = ReadInt("Введите число B: ");
ToDegree(A,B);
void ToDegree(int A,int B){
    int step =1;
    for (int i = 1; i<=B;i++){
        step = step * A;
    }
    Console.WriteLine(step);
}
int ReadInt(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());

}
