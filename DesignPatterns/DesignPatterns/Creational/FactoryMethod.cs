using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DesignPatterns.Creational
{
    public interface IProduct
    {
        string GetName();
        string SetPrice(double price);
    }

    public class IPhone : IProduct 
    {
        private double _price;
        #region IProduct Members

        public string GetName()
        {
            return "Apple TouchPad";
        }

        public string SetPrice(double price)
        {
            this._price = price;
            return "success";
        }

        #endregion
    }

    /* Almost same as Factory, just an additional exposure to do something with the created method */
    public abstract class ProductAbstractFactory
    {
        public IProduct DoSomething()
        {
            IProduct product = this.GetObject();
            //Do something with the object after you get the object. 
            product.SetPrice(20.30);
            return product;
        }
        public abstract IProduct GetObject();
    }

    public class ProductConcreteFactory : ProductAbstractFactory
    {

        public override IProduct GetObject() // Implementation of Factory Method.
        {
            return this.DoSomething();
        }
    }
}
