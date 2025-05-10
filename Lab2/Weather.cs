using System;

namespace Lab2
{
    public class Weather
    {
        private int temperature;
        private int humidity;
        private int windSpeed;

        public int Temperature { get => temperature; set => temperature = value; }

        public int Humidity { get => humidity; set => humidity = value; }

        public int WindSpeed { get => windSpeed; set => windSpeed = value; }

        public Weather()
        {
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

        public Weather(Weather other)
        {
            temperature = other.temperature;
            humidity = other.humidity;
            windSpeed = other.windSpeed;
        }

        public int GetMinValue()
        {
            return Math.Min(Math.Min(temperature, humidity), windSpeed);
        }

        public override string ToString()
        {
            return $"Температура: {temperature}°C, Влажность: {humidity}%, Скорость ветра: {windSpeed} км/ч";
        }
    }
}