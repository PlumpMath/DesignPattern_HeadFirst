using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    using System.Runtime.CompilerServices;

    public class WeatherData : IObservable<float>
    {
        private List<IObserver<float>> observers;

        private float currentTempurature;

        public WeatherData()
        {
            this.observers = new List<IObserver<float>>();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public IDisposable Subscribe(IObserver<float> observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }

            return new Unsubscriber(this.observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<float>> _observers;
            private IObserver<float> _observer;

            public Unsubscriber(List<IObserver<float>> observers, IObserver<float> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (this._observer != null && this._observers.Contains(this._observer))
                    this._observers.Remove(this._observer);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void UpdateTemperature(float tempurature)
        {
            this.currentTempurature = tempurature;
            this.NotifySubscribers();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void NotifySubscribers()
        {
            foreach (var observer in this.observers)
            {
                observer.OnNext(this.currentTempurature);
            }
        }
    }
}
