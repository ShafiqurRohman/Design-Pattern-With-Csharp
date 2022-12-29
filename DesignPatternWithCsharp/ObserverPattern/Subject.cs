using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.ObserverPattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;
         
        public void setState(int state)
        {
            this.state = state;
            notifyAllObservers();
        }

        public int getState()
        {
            return state;
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }
}
