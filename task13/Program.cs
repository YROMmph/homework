// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int Prog(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThrirdrank(int number){
    while (number > 999){
        number /= 10;
    }
    return number % 10;
}
bool validdatenumber(int number){
    if (number < 100){
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    
    return true;
}
int number = Prog("Введите число > ");
if(validdatenumber(number)){
    Console.WriteLine(GetThrirdrank(number));
}