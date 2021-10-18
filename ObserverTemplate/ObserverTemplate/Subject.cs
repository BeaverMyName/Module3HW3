using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverTemplate.Abstractions;

namespace ObserverTemplate
{
    public class Subject : ISubject
    {
        public event EventHandler EventHandler;

        public void Attach(IObserver observer)
        {
            EventHandler += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            EventHandler -= observer.Update;
        }

        public void Notify()
        {
            EventHandler?.Invoke(this, new EventArgs());
        }
    }
}
