﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class YearMonth {

        public int Year { get; private set; }

        public int Month { get; private set; }
        
        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        public bool Is21Century { 
            get {
                return 2001 <= Year && Year < 2100;
            }

            
        
        
        }

        public YearMonth AddOneMonth() {
            if (Month == 12) {
                return new YearMonth(this.Year+1,1);
            } else {
                return new YearMonth(this.Year, this.Month + 1);
            }
            

            //var YearMonth = new YearMonth(Year,Month+1);
            //if (Month > 12) {
            //    YearMonth.Month = 1;
            //    YearMonth.Year = YearMonth.Year++;
            //    return YearMonth;
            //}
            

        }
        public override string ToString() {
            return $"{Year}年{Month}月";
        }
    }
}
