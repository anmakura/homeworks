// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
static bool IsPalindrome(string s)
{
    
    for (int i = 0; i < s.Length/2; i++)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;

}
Console.WriteLine("Введите число: ");
string? s = Console.ReadLine();
int length = s.Length;
if (length != 5) Console.WriteLine("В числе не 5 цифр! Введите корректное число.");
else Console.WriteLine(IsPalindrome(s));
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string name, string point){

    Console.WriteLine($"Введите координату {name} точки {point}: ");
    return Convert.ToInt16(Console.ReadLine());


}

double dist(double x1, double x2,
            double y1, double y2,
            double z1, double z2)
{

     return Math.Sqrt(Math.Pow((x2-x1), 2) +
                      Math.Pow((y2-y1), 2) +
                      Math.Pow((z2-z1), 2));

}

double length = Math.Round(dist(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Длина отрезка = {length}");
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{

    Console.Write(Math.Pow(i, 3) + " ");

}
*/