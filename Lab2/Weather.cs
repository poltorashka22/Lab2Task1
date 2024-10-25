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
}
