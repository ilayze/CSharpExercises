using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    public class OriginalObject
    {
        public string String1 { get; set; }
        public string String2 { get; set; }
        public Memento MyMemento { get; set; }

        public OriginalObject(string str1, string str2)
        {
            this.String1 = str1;
            this.String2 = str2;
            this.MyMemento = new Memento(str1, str2);
        }
        public void Revert()
        {
            this.String1 = this.MyMemento.String1;
            this.String2 = this.MyMemento.String2;
        }
    }

    public class Memento
    {
        public string String1 { get; set; }
        public string String2 { get; set; }

        public Memento(string str1, string str2)
        {
            this.String1 = str1;
            this.String2 = str2;
        }
    }
}
