using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class WeatherForecast : Weather
    {
        private int tomorrowTemp;
        private int dayAfterTomorrowTemp;

        public WeatherForecast(int temperature, int humidity, int windSpeed, int tomorrowTemp, int dayAfterTomorrowTemp) : base(temperature, humidity, windSpeed) // Конструктор для создания прогноза погоды
        {
            this.tomorrowTemp = tomorrowTemp;
            this.dayAfterTomorrowTemp = dayAfterTomorrowTemp;
        }

        public WeatherForecast(WeatherForecast other) : base(other)// Конструктор копирования
        {
            this.tomorrowTemp = other.tomorrowTemp;
            this.dayAfterTomorrowTemp = other.dayAfterTomorrowTemp;
        }

        public bool IsTomorrowWarmerThanToday() // Метод для сравнения средней температуры
        {
            return tomorrowTemp > this.Temperature;
        }

        public double GetAverageTemperature() // Метод для вычисления средней температуры
        {
            return (this.Temperature + tomorrowTemp + dayAfterTomorrowTemp) / 3.0;
        }


        public override string ToString() // Метод ToString для формирования строки с информацией о погоде и прогнозом
        {
            return base.ToString() + $"\nСегодня: {tomorrowTemp}°C, Послезавтра: {dayAfterTomorrowTemp}°C";
        }
    }
}
