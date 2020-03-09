using System;

namespace ObserverPattern
{
    /// <summary>
    /// 订阅者
    /// </summary>
    public interface Observer
    {
        void Update(float temperature, float humidity, float pressure);
    }

    public class CurrentConditionDisply : Observer
    {
        private Subject weatherData;
        public CurrentConditionDisply(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"当前情况布告板:{temperature},{humidity},{pressure}");
        }
    }
    public class StaisticsDisply : Observer
    {
        private Subject weatherData;
        public StaisticsDisply(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"统计数据布告板:{temperature},{humidity},{pressure}");
        }
    }
    public class ForcastDisply : Observer
    {
        private Subject weatherData;
        public ForcastDisply(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"天气预报布告板:{temperature},{humidity},{pressure}");
        }
    }
}