using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural
{
    public class ParentClass
    {
        public void Method1()
        {
        }
    }

    public class DecoratorChild : ParentClass 
    {
        public void Method2()
        {
        }
    }
}
