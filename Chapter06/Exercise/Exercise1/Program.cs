using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            #endregion
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            var num2 = numbers.Reverse().Take(2);
            foreach (var item in num2) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var num3 = numbers.Select(n => n.ToString());
            foreach (var item in num3) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var num4 = numbers.OrderBy(n => n).Take(3);
            foreach (var item in num4) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine(numbers.Distinct().Count(x => x >= 10));
        }
    }
}
