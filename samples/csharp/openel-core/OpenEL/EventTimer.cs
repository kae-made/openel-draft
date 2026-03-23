using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEL
{
    public abstract class EventTimer
    {
        public List<TimerObserver> observerList { get => _timerObserver; }

        public abstract ReturnCode AddObserver(TimerObserver observer);
        public abstract ReturnCode RemoveObserver(TimerObserver observer);
        public abstract ReturnCode SetEventPeriod(ulong period);
        public abstract ReturnCode StartTimer();
        public abstract ReturnCode StopTimer();

        protected List<TimerObserver> _timerObserver = new List<TimerObserver>();
    }
}
