﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Threading;

namespace ClockFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x == 0)
            {
                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load("https://time.is");

                var node = htmlDoc.GetElementbyId("twd");

                Console.Clear();
                Console.WriteLine(node.InnerHtml);
                Thread.Sleep(400);
                
                
            }

        }

    }
}
