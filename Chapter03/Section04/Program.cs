﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s=>s.ToLower());
            var query = names.Select(s => s.Length);
            foreach(var n in query) {
                Console.WriteLine("{0}",n);
            }
        }
    }
}
