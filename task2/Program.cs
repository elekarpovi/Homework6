﻿//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
System.Console.WriteLine("Введите значения четырех переменных: ");
System.Console.Write("b1 =  ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("k1 =  ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("b2 =  ");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("k2 =  ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) 
{
     System.Console.WriteLine("Прямые совпадают и не пересекаются");
}


else
{
   double x = (b2 - b1) / (k1 - k2);
   double y = k2 * x + b2;
   
   if (k1 == k2 && (b1 < b2 || b1 > b2)) 
   {
      System.Console.WriteLine("Прямые параллельны и не пересекаются");
   }

   else
   System.Console.Write($"Координаты точки пересечения двух прямых: x = {x}, y = {y}.");  
}
