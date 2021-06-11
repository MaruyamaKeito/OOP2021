using Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var ymCollection = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,10),
            };
            Exercise2_2(ymCollection);
            Console.WriteLine("----");

            Exercise2_4(ymCollection);
            Console.WriteLine("----");

            Exercise2_5(ymCollection);
        }
        private static void Exercise2_2(YearMonth[] ymCollection) {

        }

        static YearMonth FindFirst21C(YearMonth[] yms) {

        }
        private static void Exercise2_4(YearMonth[] ymCollection) {

        }
        private static void Exercise2_5(YearMonth[] ymCollection) {

        }
    }
}
