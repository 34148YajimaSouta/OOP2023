using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {


        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, 3, 1, 6, 4, 10, 35, 2, 7, 5 };


            //5の倍数をカウント
            //int count = numbers.Count( n => n%5==0 && n>0);

            //合計値
            var sum = numbers.Where(n=>n%2==0).Sum();
            Console.WriteLine(sum);

        }

        //static public bool IsEven(int n) {
        //    return n % 2 == 0;
        //}

        //static public int Count(int[] numbers, Predicate<int> judge) {
        //    int count = 0;
        //    foreach (var n in numbers) {
        //        if (judge(n) == true) {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
