using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural
{
    /// <summary>
    /// Treats elements as composition of one or more element, so that components can be separated
    /// between one another
    /// </summary>
    public interface IComposite
    {
        void CompositeMethod();
    }

    public class LeafComposite :IComposite 
    {

        #region IComposite Members

        public void CompositeMethod()
        {
            //To Do something
        }

        #endregion
    }

    /// <summary>
    /// Elements from IComposite can be separated from others 
    /// </summary>
    public class NormalComposite : IComposite
    {

        #region IComposite Members

        public void CompositeMethod()
        {
            //To Do Something
        }

        #endregion

        public void DoSomethingMore()
        {
            //Do Something more .
        }
    }
}
