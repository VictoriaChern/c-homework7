using System;
using MyClasses;
using static System.Console;

Clear();
Write("Введите число m: ");
int m = int.Parse(ReadLine());
Write("Введите число n: ");
int n = int.Parse(ReadLine());

double[,] array = ArrayGenerator.GetArray(m, n, -10, 10, 2);

WriteLine($"m = {m}, n = {n}");
ArrayWriter.Write(array);
