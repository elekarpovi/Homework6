//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//-1, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
System.Console.Write("Введите числа одной строкой через пробел: ");

string? str = Console.ReadLine();

var array = str.Split(" ");

int [] arrint = new int [array.Length];

for (int i = 0; i < array.Length; i++)
{
    arrint[i] = Convert.ToInt32(array[i]);
}

//foreach (var item in arrint)
//{
//    System.Console.Write(" " + item);
//}

int count = 0;
foreach (var item in arrint)
{
    if (item > 0)
    count = count + 1;
}

System.Console.WriteLine($"Количество чисел больше нуля = {count}");