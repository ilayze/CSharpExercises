using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural
{
    public interface IAdapter
    {
        /// <summary>
        /// Interface method Add which decouples the actual concrete objects
        /// </summary>
        void Add();
    }
    public class MyClass1 : IAdapter
    {
        public void Add()
        {
        }
    }
    public class MyClass2
    {
        public void Push()
        {

        }
    }
    /// <summary>
    /// Implements MyClass2 again to ensure they are in same format.
    /// </summary>
    public class Adapter : IAdapter 
    {
        private MyClass2 _class2 = new MyClass2();

        public void Add()
        {
            this._class2.Push();
        }
    }
}
