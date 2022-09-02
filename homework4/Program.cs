// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень, в которую необходимо возвести число: ");
double b = Convert.ToDouble(Console.ReadLine());
var c = Math.Pow(a, b);
Console.WriteLine($"Ваше число: {c}");
*/

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.WriteLine("Введите число: ");
var a = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (a > 0)
{

    s += a % 10;
    a = a/10;

}
Console.WriteLine($"Сумма чисел: {s}");
*/

// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? nums = Console.ReadLine();

nums = nums + ",";    // дополнительня запятая для обозначения конца строки

string space (string s){
  string nnums = "";
  for (int i = 0; i < s.Length; i++)
  {
    if (s[i] != ' ') 
    {
      nnums += s[i];
    }
  }
  return nnums;
}

//  функция  проверки на правильность ввода 
void Number2 (int  s){

      if (s == '0'||s == '1'||s == '2'
      ||s == '3'||s == '4'||s == '5'||s == '6'
      ||s == '7'||s == '8'||s == '9'||s == ','
      ||s == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}

// функция  создания и заполнения массива из строки
int[] Numbers(string sn){ 

  int[] Numbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < sn.Length; i++){
    string sn1 = "";

    while (sn[i] != ',' && i < sn.Length){
      sn1 += sn[i];
      Number2(sn[i]);
      i++;
    }
    Numbers[j] = Convert.ToInt32(sn1);    // заполняет массив значениями из строки
    if (i < sn.Length-1){
      Numbers = Numbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return Numbers;
}

// функция  вывода массива на печать 
void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string sn = space(nums);

int[] narray =  Numbers(sn);

PrintArray(narray);
*/