using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DesignPatterns.Behaviourial
{
    public delegate void NotifyChangeEventHandler(string notifyinfo);
    public interface IObservable
    {
        void Attach(NotifyChangeEventHandler ohandler);
        void Detach(NotifyChangeEventHandler ohandler);
        void Notify(string name);
    }
    
    public abstract class AbstractObserver : IObservable
    {
        public void Register(NotifyChangeEventHandler handler)
        {
            this.Attach(handler);
        }

        public void UnRegister(NotifyChangeEventHandler handler)
        {
            this.Detach(handler);
        }

        public virtual void ChangeState()
        {
            this.Notify("ChangeState");
            
        }

        #region IObservable Members

        public void Attach(NotifyChangeEventHandler ohandler)
        {
            this.NotifyChanged += ohandler;
        }

        public void Detach(NotifyChangeEventHandler ohandler)
        {
            this.NotifyChanged -= ohandler;
        }

        public void Notify(string name)
        {
            if (this.NotifyChanged != null)
                this.NotifyChanged(name);
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event NotifyChangeEventHandler NotifyChanged;

        #endregion
    }

    public class Observer : AbstractObserver 
    {
        public override void ChangeState()
        {
            //Do something.
            base.ChangeState();
            
        }
    }
}
