using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var weatherPublishBoard = new WeatherPublishBoard();
            weatherPublishBoard.Subscribe(weatherData);
            Console.WriteLine("First update tempurature:");
            weatherData.UpdateTemperature(1.0f);
            Console.WriteLine("Second update tempurature:");
            weatherData.UpdateTemperature(2.0f);
            Console.WriteLine("Third update tempurature:");
            weatherData.UpdateTemperature(3.0f);
            Console.WriteLine("Unsubscribe...");
            weatherPublishBoard.Unsubscribe();
            Console.WriteLine("Forth update tempurature:");
            weatherData.UpdateTemperature(4.0f);
            Console.WriteLine("Display:");
            weatherPublishBoard.Display();
            Console.Write("Press any key to continue...");
            
            Console.ReadKey();
        }
    }
}
