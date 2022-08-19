// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string snum = Convert.ToString(num);
Console.WriteLine("Вторая цифра этого числа = "+snum[1]);
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string snum = Convert.ToString(num);

if (snum.Length > 2) {

Console.WriteLine("Третья цифра числа = "+snum[2]);

}

else {

    Console.WriteLine("Третьей цифры нет");

}
*/

// Задача 16. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7) {

    Console.WriteLine("Это выхоюдной!");

}

else if (day < 1 || day > 7) {

    Console.WriteLine("В неделе всего 7 дней... Введите корректные данные.");

}

else {

    Console.WriteLine("Это не выхоюдной!");

}
*/