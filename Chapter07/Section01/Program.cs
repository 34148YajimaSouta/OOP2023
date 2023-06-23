using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var kentyou = new Dictionary<string, CityInfo>() {
                
            };
            string city;
            int population;
            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名：");
            var kenmei =Console.ReadLine();
            while (kenmei != "999") {
                Console.Write("所在地：");
                city = Console.ReadLine();
                if (kentyou.ContainsKey(kenmei)) {
                    Console.Write("上書きしますか？y/n ");
                    if (Console.ReadLine()!="y") { continue; }                   
                }                
                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());

                kentyou[kenmei] = new CityInfo {
                    City = city,
                    Population = population,
                };

                Console.Write("県名：");
                kenmei = Console.ReadLine();
            };
            
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                foreach (var item in kentyou.OrderByDescending(x=>x.Value.Population)) {
                    Console.WriteLine("{0}【{1}(人口:{2}人)】", item.Key, item.Value.City,item.Value.Population);
                }
            }
            else {
                Console.Write("県名を入力:");
                kenmei = Console.ReadLine();
                Console.WriteLine("【{0}(人口:{1}人)】",kentyou[kenmei].City, kentyou[kenmei].Population);
            }
            
        }
    }

    class CityInfo {
        public string City { get; set; }
        public int Population { get; set; }
    }
}
