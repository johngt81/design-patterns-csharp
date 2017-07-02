using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Observer
{
    public class DocketData : ISubject
    {
        private readonly List<IObserver> _observers;

        public DocketData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers(Docket docket)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(docket);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var obsRemove = _observers.FirstOrDefault(x => x.GetType() == observer.GetType());
            if (obsRemove != null) _observers.Remove(obsRemove);
        }

        public void NewDocketAdded(Docket data)
        {
            NotifyObservers(data);
        }
    }
}
