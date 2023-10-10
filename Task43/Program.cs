// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Intersection(double b1, double k1, double b2, double k2) { // Функция отправляет значение X.
    if(k1 - k2 == 0 && b2 - b1 == 0) return 0;
    return (b2 - b1)/(k1 - k2);
}

Console.Write("Введите первую точку первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую точку второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double resx = Intersection(b1, k1, b2, k2); 
if(k1 - k2 == 0 && b2 - b1 != 0) Console.WriteLine("Нет Решений!");
else {
    double resy = k2 * resx + b2;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({resx}, {resy})");
}
