using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Weather
    {
        private int temperature { get; set; }
        private int humidity {  get; set; }
        private int windSpeed {  get; set; }

        public int Temperature { get => temperature; set => temperature = value; }
        public int Humidity { get => humidity; set => humidity = value; }   
        public int WindSpeed { get => windSpeed; set => windSpeed = value; }



        public Weather() { // конструктор по усолчанию
            temperature = 1;
            humidity = 1;
            windSpeed = 1;
        }

        public Weather(int temperature, int humidity, int windSpeed)
        {
        this.temperature = temperature;
        this.humidity = humidity;
        this.windSpeed = windSpeed;
        }

        public Weather(Weather other) // конструктор копирования
        {
            temperature = other.temperature;
            humidity = other.humidity;
            windSpeed = other.windSpeed;
        }

        public int GetMinValue() // Метод для получения минимального значения из полей погоды
        {
            return Math.Min(Math.Min(temperature, humidity), windSpeed);
        }

        public override string ToString() // Переопределенный метод ToString для формирования строки с информацией о погоде
        {
            return $"Температура: {temperature}°C, Влажность: {humidity}%, Скорость ветра: {windSpeed} км/ч";
        }
    }

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
