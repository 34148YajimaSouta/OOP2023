﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        public int Year { get; private set; }

        public int Month { get; private set; }

        

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        public bool Is21Century {
            get {
                return Year >= 2001 && Year <= 2100;
            }
        }

        //public YearMonth AddOneMonth() {

        //}

        public override string ToString() {
            return base.ToString();
        }
    }
    
}
