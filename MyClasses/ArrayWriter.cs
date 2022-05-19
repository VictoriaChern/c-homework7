namespace MyClasses;

using System;

public class ArrayWriter {

    public static void Write(int[,] array) {
        for(int i = 0; i < array.GetLength(0); i++) {
            for(int j = 0; j < array.GetLength(1); j++) {
               Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void Write(double[,] array) {
        for(int i = 0; i < array.GetLength(0); i++) {
            for(int j = 0; j < array.GetLength(1); j++) {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}