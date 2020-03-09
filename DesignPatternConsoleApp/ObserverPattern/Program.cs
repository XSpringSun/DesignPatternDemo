using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisply currentConditionDisply = new CurrentConditionDisply(weatherData);
            StaisticsDisply staisticsDisply = new StaisticsDisply(weatherData);
            ForcastDisply forcastDisply = new ForcastDisply(weatherData);
            weatherData.SetMeasurments(30, 65, 30.5F);
            Console.WriteLine("---------------移除订阅者-----------");
            weatherData.RemoveObserver(currentConditionDisply);
            weatherData.SetMeasurments(31,55,20);
            Console.WriteLine("---------------添加订阅者-----------");
            weatherData.RegisterObserver(currentConditionDisply);
            weatherData.SetMeasurments(30, 55, 30.5F);
            Console.ReadKey();
        }
    }
}
