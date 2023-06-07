﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            Console.WriteLine(numbers[numbers.Length - 1]+" "+numbers[numbers.Length - 2]);
        }

        private static void Exercise1_3(int[] numbers) {
            var stringNumbers = numbers.Select(n => n.ToString());
            foreach (var stringNum in stringNumbers) {
                Console.WriteLine(stringNum);
            }
            
        }

        private static void Exercise1_4(int[] numbers) {
            var numberObj = numbers.OrderBy(n=>n).ToArray();
            foreach (var num in numberObj.Take(3)) {
                Console.WriteLine(num);
            }
        }

        private static void Exercise1_5(int[] numbers) {
        }
    }
}
