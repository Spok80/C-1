// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InputNumber();
double k1 = InputNumber();
double b2 = InputNumber();
double k2 = InputNumber();

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Нет точек пересечения, прямые параллельны");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    Console.WriteLine($"Точка пересечания 2 прямых ({x}; {y})");
}


double InputNumber()
{
    Console.WriteLine("Введите значение");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}