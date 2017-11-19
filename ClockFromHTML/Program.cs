using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ClockFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            HTMLString htmlreader = new HTMLString();
            StreamReader sr = htmlreader.ReadHTMLStream("https://time.is");
            using (sr)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadKey();
        }

    }
}
