using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {
            int[] chengeMoney = { 10000, 5000, 2000,1000, 500, 100, 50, 10, 5, 1 };
            Console.Write("金額:");
            int sum = int.Parse(Console.ReadLine());
            Console.Write("支払い:");
            int money = int.Parse(Console.ReadLine());
            int chenge = money-sum;
            Console.WriteLine("お釣り:"+chenge);
            for (int i = 0; i < chengeMoney.Length; i++)
            {
                Console.Write(chengeMoney[i] + "円:" );
                for(int j = 0; j < chenge / chengeMoney[i]; j++)
                {
                    Console.Write("*");
                }
                chenge %= chengeMoney[i];
                Console.WriteLine();
            }
            
        }
    }
}
