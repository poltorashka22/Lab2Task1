using Lab2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Weather weatherDefault = new Weather();
        Console.WriteLine("Погода инициализирована конструктором по умолчанию:");
        Console.WriteLine(weatherDefault);
        Console.WriteLine($"Минимальное значение: {weatherDefault.GetMinValue()}\n");

        int temperature = ReadIntWithValidation("Введите температуру (-50°C to 50°C): ", -50, 50, "Температура");
        int humidity = ReadIntWithValidation("Введите влажность воздуха (0% - 100%): ", 0, 100, "Влажность");
        int windSpeed = ReadIntWithValidation("Введите скорость ветра (0 до 118 км/ч): ", 0, 118, "Скорость ветра");

        int tomorrowTemp = ReadIntWithValidation("Введите температуру на завтра (-50°C to 50°C): ", -50, 50, "Температура на завтра");
        int dayAfterTomorrowTemp = ReadIntWithValidation("Введите температуру на послезавтра (-50°C to 50°C): ", -50, 50, "Температура на послезавтра");

        WeatherForecast forecast = new WeatherForecast(temperature, humidity, windSpeed, tomorrowTemp, dayAfterTomorrowTemp);
        Console.WriteLine("\nПрогноз погоды:");
        Console.WriteLine(forecast);
        Console.WriteLine($"Завтра будет теплее, чем сегодня? {forecast.IsTomorrowWarmerThanToday()}");
        Console.WriteLine($"Средняя температура за 3 дня: {forecast.GetAverageTemperature():F1}°C");

        try
        {
            WeatherForecast forecastCopy = new WeatherForecast(forecast);
            Console.WriteLine("\nСкопированный прогноз погоды:");
            Console.WriteLine(forecastCopy);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка при копировании: {ex.Message}");
        }

        Console.ReadKey();
    }

    private static int ReadIntWithValidation(string prompt, int min, int max, string paramName)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()?.Trim() ?? string.Empty;

            if (int.TryParse(input, out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                Console.WriteLine($"\nОшибка! {paramName} должна быть в диапазоне от {min} до {max}.");
            }
            else
            {
                Console.WriteLine("\nОшибка! Введите корректное целое число.");
            }
        }
    }
}
