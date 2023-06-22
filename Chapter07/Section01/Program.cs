using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var kentyou = new Dictionary<string, string>() {
                
            };
            string shozaiti;
            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名：");
            var kenmei =Console.ReadLine();
            while (kenmei != "999") {
                Console.Write("所在地：");
                shozaiti = Console.ReadLine();
                if (kentyou.ContainsKey(kenmei)) {
                    Console.Write("上書きしますか？y/n ");
                    if (Console.ReadLine()=="y") { kentyou[kenmei] = shozaiti; }                   
                }
                else { kentyou[kenmei] = shozaiti; }
                Console.Write("県名：");
                kenmei = Console.ReadLine();
            };

            Console.Write("県名を入力:");
            kenmei = Console.ReadLine();
            Console.WriteLine(kentyou[kenmei]+"です");

            
        }
    }
}
