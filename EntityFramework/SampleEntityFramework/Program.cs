using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1,1");
            //Exercise13_1_1();
            Console.WriteLine("#1,2");
            Exercise13_1_2();
            Console.WriteLine("#1,3");
            Exercise13_1_3();
            Console.WriteLine("#1,4");
            Exercise13_1_4();
            Console.WriteLine("#1,5");
            Exercise13_1_5();

            Console.ReadLine();//F5で実行してもすぐコンソール画面が消えないようにする
        }

        private static void Exercise13_1_1()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = new Author
                    {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book2);

                var book3 = new Book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book3);

                var book4 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1896, 8, 27),
                        Gender = "M",
                        Name = "宮沢賢治",
                    }
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }

        private static void Exercise13_1_2()
        {
            using (var db = new BooksDbContext())
            {
                IEnumerable<Book> books = db.Books.ToList();
                foreach (var book in books)
                {
                    Console.Write(book.Title + "  ");
                    Console.Write(book.PublishedYear + "  ");
                    Console.WriteLine(book.Author.Name);
                    Console.WriteLine();
                }
            }
        }

        private static void Exercise13_1_3()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books.Where(x => x.Title.Length == db.Books.Max(y => y.Title.Length));
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                    Console.WriteLine(book.PublishedYear);
                    Console.WriteLine(book.Author.Name);
                }
            }
        }

        private static void Exercise13_1_4()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books.OrderBy(x => x.PublishedYear).ToList();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(books[i].Title);
                    Console.WriteLine(books[i].PublishedYear);
                    Console.WriteLine(books[i].Author.Name);
                }
            }
        }

        private static void Exercise13_1_5()
        {
            using (var db = new BooksDbContext())
            {
                var authors = db.Authors.OrderByDescending(x => x.Birthday).ToList();
                foreach (var item in authors)
                {
                    Console.WriteLine(item.Name + item.Birthday.ToString("yyyy/MM/dd"));
                    var books = db.Books.Where(x => x.Author.Name == item.Name).ToList();
                    foreach (var book in books)
                    {
                        Console.WriteLine(book.Title);
                        Console.WriteLine(book.PublishedYear);
                        Console.WriteLine("  ");
                    }
                }
            }
        }
    }
}