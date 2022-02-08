using System;
using System.Collections.Generic;

namespace Sortintg_Algorithem {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            List<int> numbers = new List<int>();
            int length = numbers.Count;
            for (int i = 0; i < 100; i++) {
                numbers.Add(rand.Next(0, 101));
            }

            Display(numbers);
            Console.ReadKey();

            bubbleSort(numbers,length);
            Console.WriteLine("Sorted array");
            printArray(numbers,length);

            Console.ReadKey();
        }
        static void Display(List<int> lyst) {
            for (int i = 0; i < lyst.Count; i++) {
                if (i % 25 == 0) {
                    Console.WriteLine();
                } else {
                    Console.Write(lyst[i] + " ");
                }
            }
        }

        // === === === === === === === === === === === \\
        // === === === Sorting algorithems === === === \\
        // === === === === === === === === === === === \\

        static void bubbleSort(List<int> numbers, int n) { // Suspected culprit as to why code is broken
        int i, j, temp;
        bool swapped;
        for (i = 0; i < n - 1; i++) {
            swapped = false;
            for (j = 0; j < n - i - 1; j++) {
                if (numbers[j] > numbers[j + 1]) {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                    swapped = true;
                }
            }

            if (swapped == false) {
                break;
            }
        }
    }

    static void printArray( List<int> numbers, int size) { // Suspected culprit as to why code is broken
        int i;
        for (i = 0; i < size; i++)
            Console.Write(numbers[i] + " ");
        Console.WriteLine();
    }
    }
}
