using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational
{
    public interface IFactory1
    {
        IPeople GetPeople();
    }
    public class Factory1 : IFactory1
    {
        public IPeople GetPeople()
        {
            return new Villagers();
        }
    }

    public interface IFactory2
    {
        IProduct GetProduct();
    }
    public class Factory2 : IFactory2
    {
        public IProduct GetProduct()
        {
            return new IPhone();
        }
    }

    public abstract class AbstractFactory12
    {
        public abstract IFactory1 GetFactory1();
        public abstract IFactory2 GetFactory2();
    }

    public class ConcreteFactory : AbstractFactory12
    {

        public override IFactory1 GetFactory1()
        {
            return new Factory1();
        }

        public override IFactory2 GetFactory2()
        {
            return new Factory2();
        }
    }
}
