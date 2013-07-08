using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational
{
    public abstract class Prototype
    {
       
        // normal implementation

        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class ConcretePrototype2 : Prototype
    {

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone(); // Clones the concrete class.
        }
    }

}
