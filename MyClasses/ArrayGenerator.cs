namespace MyClasses;

using System;
public class ArrayGenerator {

    public static int[,] GetArray(int rows, int column, int max) {
        return GetArray(rows, column, 0, max);
    }
    public static int[,] GetArray(int rows, int column, int min, int max) {
        int[,] array = new int[rows,column];
        Random random = new Random();
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < column; j++) {
                array[i,j] = random.Next(min,max);
            }
        }
        return array;
    }

    public static double[,] GetArray(int rows, int column, double max, int digits) {
        return GetArray(rows, column, max, digits);
    }
    
    public static double[,] GetArray(int rows, int column, double min, double max, int digits) {
        double[,] array = new double[rows,column];
        Random random = new Random();
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < column; j++) {
                array[i,j] = Math.Round(random.NextDouble() * (max - min) + min, digits);
            }
        }
        return array;
    }
}
