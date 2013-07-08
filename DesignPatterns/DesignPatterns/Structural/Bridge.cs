using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural
{

    # region The Implementation
    /// <summary>
    /// Helps in providing truely decoupled architecture
    /// </summary>
    public interface IBridge
    {
        void Function1();
        void Function2();
    }

    public class Bridge1 : IBridge
    {

        #region IBridge Members

        public void Function1()
        {
            throw new NotImplementedException();
        }

        public void Function2()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class Bridge2 : IBridge
    {
        #region IBridge Members

        public void Function1()
        {
            throw new NotImplementedException();
        }

        public void Function2()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    # endregion

    # region Abstraction
    public interface IAbstractBridge
    {
        void CallMethod1();
        void CallMethod2();
    }

    public class AbstractBridge : IAbstractBridge 
    {
        public IBridge bridge;

        public AbstractBridge(IBridge bridge)
        {
            this.bridge = bridge;
        }
        #region IAbstractBridge Members

        public void CallMethod1()
        {
            this.bridge.Function1();
        }

        public void CallMethod2()
        {
            this.bridge.Function2();
        }

        #endregion
    }
    # endregion
}
