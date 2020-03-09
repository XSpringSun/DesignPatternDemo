using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 主题
    /// </summary>
    public interface Subject
    {
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
        public void NotifyObserver();
    }
    /// <summary>
    /// 具体主题(气象站)
    /// </summary>
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            observers.Remove(o);
        }

        //通知观察者
        public void NotifyObserver()
        {
            foreach (var o in observers)
            {
                o.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurmentsChanged()
        {
            NotifyObserver();
        }

        //数据变化
        public void SetMeasurments(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurmentsChanged();
        }
    }
}
