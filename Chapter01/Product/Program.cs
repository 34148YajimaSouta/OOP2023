using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daihuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("かりんとうの税込み価格：" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("大福もちの税込み価格：" + daihuku.GetPriceIncludingTax());
            #endregion

            //DateTime date = new DateTime(2023, 5, 8);
            TimeSpan totalDays;
            DateTime date = DateTime.Now;
            Console.Write("西暦:");
            int years = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            DateTime birth = new DateTime(years, month, day);

            totalDays = date - birth;
            Console.WriteLine("あなたは生まれてから今日まで{0}日目です", totalDays.Days);
        }


    }
}
