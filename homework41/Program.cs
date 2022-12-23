/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите числа через пробел");
var str = Console.ReadLine() ?? "";

int[] arr = Array.ConvertAll(str.Split(' '), int.Parse);

int posSum = 0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0) posSum++;

Console.WriteLine($"Количество чисел больше 0 : {posSum}");
