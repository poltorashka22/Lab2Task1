namespace Lab2
{
    public class WeatherForecast : Weather
    {
        private int _tomorrowTemp;
        private int _dayAfterTomorrowTemp;

        public WeatherForecast(int todayTemperature, int humidity, int windSpeed,
                             int tomorrowTemp, int dayAfterTomorrowTemp)
            : base(todayTemperature, humidity, windSpeed)
        {
            this._tomorrowTemp = tomorrowTemp;
            this._dayAfterTomorrowTemp = dayAfterTomorrowTemp;
        }

        public WeatherForecast(WeatherForecast other) : base(other)
        {
            this._tomorrowTemp = other._tomorrowTemp;
            this._dayAfterTomorrowTemp = other._dayAfterTomorrowTemp;
        }

        public bool IsTomorrowWarmerThanToday()
        {
            return _tomorrowTemp > Temperature;
        }

        public double GetAverageTemperature()
        {
            return (Temperature + _tomorrowTemp + _dayAfterTomorrowTemp) / 3.0;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЗавтра: {_tomorrowTemp}°C, Послезавтра: {_dayAfterTomorrowTemp}°C";
        }
    }
}
