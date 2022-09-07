// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Введите элементы (через пробел): ");
int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < ar.Length; i++)
{
    if (ar[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше нуля: {count}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.WriteLine("Введите k1: ");
float  k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
float x, y;

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны");
else  
{

    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine($"Точка пересечения имееи координаты ({x}; {y})");
}
*/