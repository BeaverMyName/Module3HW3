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
        private EventHandler _eventHandler;

        public void Attach(IObserver observer)
        {
            _eventHandler += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            _eventHandler -= observer.Update;
        }

        public void Notify()
        {
            _eventHandler?.Invoke(this, new EventArgs());
        }
    }
}
