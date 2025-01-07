﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book()
                {
                    Title = "ADO.Net Step by Step", Price = 5
                },
                new Book(){Title = "ASP .NET MVC", Price = 9.99f},
                new Book(){Title = "ASP .NET Web API", Price = 15},
                new Book(){Title = "C# Advanced Topics", Price = 5},
                new Book(){Title = "C# Advanced Topics", Price = 5}

            };
        }
    }
}
