using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Secsion01
{
    class Program
    {
        static void Main(string[] args)
        {


            foreach (var novelist in novelists)
            {
                Console.WriteLine("{0} ({1}-{2})", novelist.Name, novelist.Birth, novelist.Death.Year);
            }
        }

        public IEnumerable<Novelist> ReadNovelists()
        {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                                   .Select(x => new
                                   {
                                       Name = (String)x.Element("name"),
                                       Birth = (DateTime)x.Element("birth"),
                                       Death = (DateTime)x.Element("death")
                                   });
        }
    }
}

