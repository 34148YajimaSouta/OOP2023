﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            // 2019/1/15 19:48
            var str1 = dateTime.ToString("d");
            var str2 = dateTime.ToString("t");
            Console.WriteLine("{0} {1}",str1,str2);
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            // 2019年01月15日 19時48分32秒
            Console.WriteLine(dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            // 平成31年 1月15日(火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var datestr = dateTime.ToString("ggyy年 M月d日", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            var str = string.Format("{0}({1})", datestr, dayOfWeek);
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var dateStr = dateTime.ToString("ggyy年MM月dd日 (dddd)", culture);
            Console.WriteLine(dateStr);

        }
    }
}
