
using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var ymCollection = new YearMonth[] {
            new YearMonth (1999, 1),
            new YearMonth(2001, 5),
            new YearMonth(2004, 7),
            new YearMonth(2009, 9),
            new YearMonth(2015, 12),
        };
            Exercise2_2(ymCollection);
            Console.WriteLine("-----");

            Exercise2_4(ymCollection);
            Console.WriteLine("-----");

            Exercise2_5(ymCollection);
            Console.WriteLine("-----");

        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);

            }
        }

        static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }


        private static void Exercise2_4(YearMonth[] ymCollection) {
            var ymcheck = FindFirst21C(ymCollection);
            if(ymcheck != null) {
                Console.WriteLine(ymcheck.Year);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var select = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in select) {
                Console.WriteLine(ym);
            }
        }
    }
}
