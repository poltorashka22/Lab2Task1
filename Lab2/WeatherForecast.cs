namespace Lab2
{
    public class WeatherForecast : Weather
    {
        private int tomorrowTemp;
        private int dayAfterTomorrowTemp;

        public WeatherForecast(int todayTemperature, int humidity, int windSpeed,
                             int tomorrowTemp, int dayAfterTomorrowTemp)
            : base(todayTemperature, humidity, windSpeed)
        {
            this.tomorrowTemp = tomorrowTemp;
            this.dayAfterTomorrowTemp = dayAfterTomorrowTemp;
        }

        public WeatherForecast(WeatherForecast other) : base(other)
        {
            this.tomorrowTemp = other.tomorrowTemp;
            this.dayAfterTomorrowTemp = other.dayAfterTomorrowTemp;
        }

        public bool IsTomorrowWarmerThanToday()
        {
            return tomorrowTemp > Temperature;
        }

        public double GetAverageTemperature()
        {
            return (Temperature + tomorrowTemp + dayAfterTomorrowTemp) / 3.0;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЗавтра: {tomorrowTemp}°C, Послезавтра: {dayAfterTomorrowTemp}°C";
        }
    }
}
