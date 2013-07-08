using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behaviourial
{
    public interface IComponent
    {
        void SetState(object state);
    }
    public class Component1 : IComponent
    {
        #region IComponent Members

        public void SetState(object state)
        {
            //Do Nothing
            throw new NotImplementedException();
        }

        #endregion
    }

    public class Component2 : IComponent
    {

        #region IComponent Members

        public void SetState(object state)
        {
            //Do nothing
            throw new NotImplementedException();
        }

        #endregion
    }

    public class Mediator // Mediages the common tasks
    {
        public IComponent Component1 { get; set; }
        public IComponent Component2 { get; set; }

        public void ChageState(object state)
        {
            this.Component1.SetState(state);
            this.Component2.SetState(state);
        }
    }
}
