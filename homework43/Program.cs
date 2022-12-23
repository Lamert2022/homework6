/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int GetValue(string varname)
{
    Console.Write($"Введите значение {varname}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int b1 = GetValue("b1");
int k1 = GetValue("k1");
int b2 = GetValue("b2");
int k2 = GetValue("k2");

double x = (double)(b1 - b2) / (k1 - k2) * -1;
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({x}; {y})");

