using System;

namespace ObserverTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subject = new Subject();
            var firstObserver = new Observer();
            var secondObserver = new Observer();

            subject.Attach(firstObserver);
            subject.Attach(secondObserver);

            subject.Notify();

            subject.Detach(firstObserver);

            subject.Notify();
        }
    }
}
