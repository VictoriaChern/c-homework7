using System;
using MyClasses;
using static System.Console;

Clear();

int[,] array = ArrayGenerator.GetArray(4,3,10);
double[] avgs = new double[array.GetLength(1)];

for(int column = 0; column < array.GetLength(1); column++) {
    int sum = 0;
    for(int row = 0; row < array.GetLength(0); row++) {
        sum += array[row,column];
    }
    avgs[column] = sum / array.GetLength(0);
}

ArrayWriter.Write(array);
WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ",avgs)}");