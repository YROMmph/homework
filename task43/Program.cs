// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1=1;
const int line2=2;

double[] linedata1 = InputLineData(line1);
double[] linedata2 = InputLineData(line2);

if (ValidateLines(linedata1,linedata2)){
    double[] coord = findCoords(linedata1,linedata2);
    Console.Write($"Точка пересечения уравнений y={linedata1[coefficient]}*x+{linedata1[constant]} и y={linedata2[coefficient]}*x+{linedata2[constant]} ");
    Console.WriteLine($"имеет координаты ({coord[x_coord]}, {coord[y_coord]})");
}
double Prompt(string message){
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLinedata(int numberOfLine){
    double[] linedata = new double[2];
    linedata[coefficient] = Prompt($"введите коэфициент для {numberOfLine} прямой >");
    linedata[constant] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return linedata;

}
double[] findCoords (double[] linedata1, double[] linedata2){
    double[] coord = new double[2];
    coord[x_coord]=(linedata1[constant]- linedata2[constant]) / (linedata2[coefficient]-linedata1[coefficient]);
    coord[y_coord]=linedata1[constant]* coord[x_coord]+ linedata1[constant];
    return coord;
}
bool ValidateLines(double[] linedata1, double[] linedata2){
    if (linedata1[coefficient]== linedata2[coefficient]){
        if (linedata1[constant]== linedata2[constant]){
            Console.WriteLine("Прямые совпадают");
            return false;
        } else{
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}