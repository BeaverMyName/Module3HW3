using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTemplate.Abstractions
{
    public interface IObserver
    {
        public void Update(object sender, EventArgs args);
    }
}
