using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverTemplate.Abstractions;

namespace ObserverTemplate
{
    public class Observer : IObserver
    {
        private readonly Guid _guid;

        public Observer()
        {
            _guid = Guid.NewGuid();
        }

        public void Update(object sender, EventArgs args)
        {
            Console.WriteLine($"User: {_guid} got a message");
        }
    }
}
