
// Задание 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {

    Console.WriteLine($"Max = {a}");

}

else {

    Console.WriteLine($"Max = {b}");

} 
*/

// Задание 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) {

    Console.WriteLine($"Max = {a}");

}

else if (b > a && b > c) {

    Console.WriteLine($"Max = {b}");

} 

else if (c > a && c > b) {

    Console.WriteLine($"Max = {c}");

}
else {

    Console.WriteLine("Числа равны");

}
*/

// Задание 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число для проверки четности: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) {

    Console.WriteLine("Число четное");

}
else {

    Console.WriteLine("Число нечетное");

}
*/

// Задание 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++) {
    if (i % 2 == 0){
        Console.Write($"{i} ");
    }
}
*/