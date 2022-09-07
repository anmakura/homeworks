// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int size = 20;
int[] array = new int[size];
Random rand = new Random();
int c = 0;

for (int i = 0; i < size; i++)


{

     array[i] = rand.Next(100, 999);
     Console.Write(array[i] + " ");

    if (array[i] % 2 == 0) c+=1;
   
}



Console.WriteLine($"\nЧетных чисел {c}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] ar = new int[20];
List<int> odd = new List<int>();
var rand = new Random();
int sum = 0;
for (int i = 0; i < 20; i++)
{

ar[i] = rand.Next(100, 999);

}

for (int j = 0; j < 20; j++)
{

if (j % 2 != 0) odd.Add(ar[j]);

}

for (int k = 0; k < odd.Count; k++)
{

sum = sum + odd[k];

}

var str = string.Join(" ", ar);
var str1 = string.Join(" ", odd);
Console.WriteLine(str);
Console.WriteLine(str1);
Console.WriteLine(sum);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] ar = new double[10];
Random rand = new Random();
double maxV = 0;
double minV = 0;

for (int i = 0; i < ar.Length; i++)
{

    ar[i] = rand.NextDouble();

}

maxV = ar.Max();
minV = ar.Min();
var str = string.Join(" ", ar);
double sum = maxV + minV;

Console.WriteLine(str);
Console.WriteLine($"Сумма минимального и максимального членов массива: {Math.Round(sum, 2)}");
*/