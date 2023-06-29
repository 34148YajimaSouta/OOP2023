﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            var replaced =text.ToUpper();
            Console.WriteLine(replaced);
            foreach (var ch in replaced) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch] += 1;
                    }
                    else {
                        dict[ch] = 1;
                    }
                }
                
            }
            foreach (var item in dict.OrderBy(c=>c.Key)) {
                Console.WriteLine("'{0}':{1}", item.Key, item.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            var replaced = text.ToUpper();
            Console.WriteLine(replaced);
            foreach (var ch in replaced) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch] += 1;
                    }
                    else {
                        dict[ch] = 1;
                    }
                }

            }
            foreach (var item in dict) {
                Console.WriteLine("'{0}':{1}", item.Key, item.Value);
            }
        }
    }
}
