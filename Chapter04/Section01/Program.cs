using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if(product.Name == "") {
                //productが取得できなかったときの処理
                Console.WriteLine("productが取得できなかった");
            } else {
                //productが取得できたときの処理
                Console.WriteLine("productが取得できた");
            }
        }
          private static Product GetProductA() {
            Sale sale = new Sale();
            return sale?.Product;  //null条件演算子
          }
    }
    class Sale {
        public string ShopName { get; set; }
        public string Amount { get; set; }
        public Product Product { get; set; }
    }
}
