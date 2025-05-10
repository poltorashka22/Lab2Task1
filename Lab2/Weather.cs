using System;

namespace Lab2
{
    public class Weather
    {
        private int _temperature;
        private int _humidity;
        private int _windSpeed;

        public int Temperature { get => _temperature; set => _temperature = value; }

        public int Humidity { get => _humidity; set => _humidity = value; }

        public int WindSpeed { get => _windSpeed; set => _windSpeed = value; }

        public Weather()
        {
            _temperature = 1;
            _humidity = 1;
            _windSpeed = 1;
        }

        public Weather(int temperature, int humidity, int windSpeed)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._windSpeed = windSpeed;
        }

        public Weather(Weather other)
        {
            _temperature = other._temperature;
            _humidity = other._humidity;
            _windSpeed = other._windSpeed;
        }

        public int GetMinValue()
        {
            return Math.Min(Math.Min(_temperature, _humidity), _windSpeed);
        }

        public override string ToString()
        {
            return $"Температура: {_temperature}°C, Влажность: {_humidity}%, Скорость ветра: {_windSpeed} км/ч";
        }
    }
}