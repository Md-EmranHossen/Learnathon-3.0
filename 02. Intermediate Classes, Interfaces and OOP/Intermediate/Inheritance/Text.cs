﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Text:PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName {  get; set; }

        public void addHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
