using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    using System.Runtime.CompilerServices;

    public class WeatherPublishBoard : IObserver<float>, IDisplay
    {
        private float currentTemperature;

        private float maxTemperature = float.MinValue;

        private float minTemperature = float.MaxValue;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Update(float temperature)
        {
            this.currentTemperature = temperature;
            if (temperature > this.maxTemperature)
            {
                this.maxTemperature = temperature;
            }

            if (temperature < this.minTemperature)
            {
                this.minTemperature = temperature;
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Display()
        {
            Console.WriteLine(
                "Current temperature is {0}, max is {1}, min is {2}",
                this.currentTemperature,
                this.maxTemperature,
                this.minTemperature);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void OnNext(float value)
        {
            this.Update(value);
            this.Display();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void OnError(Exception error)
        {
            Console.WriteLine("OnError: {0}", error.Message);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void OnCompleted()
        {
            Console.WriteLine("OnCompleted.");
        }
    }
}
