﻿// Напишите программу, которая на вход принимает число и выдает квадрат этого числа
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine() ); 
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");
