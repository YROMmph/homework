// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int Prog(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool isweekend(int weekday){
    if (weekday >5){
        return true;
    }
    return false;
}
bool validdateweekday(int number){
    if (number > 0 && number <= 7){
        return true;
    }
    Console.WriteLine("Неверно введен день недели");
    return false;
}
int weekday = Prog("Ввкдите день недели >");
if(validdateweekday(weekday)){
    if (isweekend(weekday)){
        Console.WriteLine("выходной");
    }
    else{
        Console.WriteLine("Рабочий день");
    }
}