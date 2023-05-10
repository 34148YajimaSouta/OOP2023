using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintToMaterList(1, 10);
            }
            else {
                PrintToFeetList(1, 10);
            }
        }

        //フィートからメートルへの対応表を出力
        private static void PrintToMaterList(int start, int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double mater = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0}ft={1:0.0000}m", feet, mater);
            }
        }

        private static void PrintToFeetList(int start, int stop) {
            //メートルからフィートへの対応表を出力    
            for (int meter = start; meter <= stop; meter++) {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0}m={1:0.0000}ft", meter, feet);
            }
        }
    }
}
