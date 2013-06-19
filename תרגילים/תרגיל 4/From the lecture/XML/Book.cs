using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XML
{
    public class Book
    {
        public string name;
        public string publisher;
        public int numOfPages;
        public string[] authors;

        public Book()
        {
        }
        public Book(string name, string publisher, int num, string[] authors)
        {
            this.name = name;
            this.publisher = publisher;
            numOfPages = num;
            this.authors = authors;
        }
    }
}
