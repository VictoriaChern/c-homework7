using System;
using MyClasses;
using static System.Console;

Clear();

int[,] array = ArrayGenerator.GetArray(4,5,10);

Write("Введите номер строки: ");
int row = int.Parse(ReadLine());
Write("Введите номер столбца: ");
int column = int.Parse(ReadLine());

ArrayWriter.Write(array);
if(row < 0 || row >= array.GetLength(0)) {
    WriteLine($"{row}, {column} -> такой позиции в массиве нет");
    return;
}
if(column < 0 || column >= array.GetLength(1)) {
    WriteLine($"{row}, {column} -> такой позиции в массиве нет");
    return;
}

WriteLine($"{row}, {column} -> {array[row,column]}");



