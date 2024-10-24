using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта Weather с использованием конструктора по умолчанию
        Weather weatherDefault = new Weather();
        Console.WriteLine("Погода инициализирована конструктором по умолчанию:");
        Console.WriteLine(weatherDefault);
        Console.WriteLine($"Минимальное значение: {weatherDefault.GetMinValue()}");

        // Создание объекта Weather с конкретными значениями погоды
        int temperature, humidity, windSpeed;

        while (true)
        {
            Console.Write("Введите температуру (-50°C to 50°C): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                if (!char.IsDigit(input[0]))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                int parsedTemp;
                if (!int.TryParse(input, out parsedTemp))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                if (parsedTemp < -50 || parsedTemp > 50)
                {
                    Console.WriteLine("\nОшибка! Температура должна быть в диапазоне от -50 до 50.");
                    continue;
                }

                temperature = parsedTemp;
                break;
            }

        }

        while (true)
        {
            Console.Write("Введите влажность воздуха (0% - 100%): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                if (!char.IsDigit(input[0]))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                int parsedHumidity;
                if (!int.TryParse(input, out parsedHumidity))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                if (parsedHumidity < 0 || parsedHumidity > 100)
                {
                    Console.WriteLine("\nОшибка! Влажность воздуха должна быть в диапазоне от 0 до 100 процентов.");
                    continue;
                }

                humidity = parsedHumidity;
                break;
            }

        }

        while (true)
        {
            Console.Write("Введите скорость ветра (0 до 118 км/ч): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                if (!char.IsDigit(input[0]))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                int parsedWindSpeed;
                if (!int.TryParse(input, out parsedWindSpeed))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                if (parsedWindSpeed < 0 || parsedWindSpeed > 118)
                {
                    Console.WriteLine("\nОшибка! Атмосферное давление должно быть в диапазоне от 0 до 118 км/ч");
                    continue;
                }

                windSpeed = parsedWindSpeed;
                break;
            }
        }

        // Создание объекта WeatherForecast с конкретными значениями погоды и прогнозом
        int tomorrowTemp, dayAfterTomorrowTemp;

        while (true)
        {
            Console.Write("Введите сегодняшнюю температуру (-50°C to 50°C): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                if (!char.IsDigit(input[0]))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                int parsedTemp;
                if (!int.TryParse(input, out parsedTemp))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                if (parsedTemp < -50 || parsedTemp > 50)
                {
                    Console.WriteLine("\nОшибка! Температура должна быть в диапазоне от -50 до 50.");
                    continue;
                }

                tomorrowTemp = parsedTemp;
                break;
            }

        }

        while (true)
        {
            Console.Write("Введите температуру которая должна быть завтра (-50°C to 50°C): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                if (!char.IsDigit(input[0]))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                int parsedTemp;
                if (!int.TryParse(input, out parsedTemp))
                {
                    Console.WriteLine("\nОшибка! Введите пожалуйста корректное значение.");
                    continue;
                }

                if (parsedTemp < -50 || parsedTemp > 50)
                {
                    Console.WriteLine("\nОшибка! Температура должна быть в диапазоне от -50 до 50.");
                    continue;
                }

                dayAfterTomorrowTemp = parsedTemp;

                break;
            }

        }

        WeatherForecast forecast = new WeatherForecast(temperature, humidity, windSpeed, tomorrowTemp, dayAfterTomorrowTemp);
        Console.WriteLine("\nПрогноз погоды:");
        Console.WriteLine(forecast);
        Console.WriteLine($"Завтра будет теплее, чем сегодня? {forecast.IsTomorrowWarmerThanToday()}");
        Console.WriteLine($"Сегодня температура: {forecast.GetAverageTemperature()}");


        // Тестирование конструктора копирования
        try
        {
            WeatherForecast forecastCopy = new WeatherForecast(forecast);
            Console.WriteLine("\nСкопированный прогноз погоды:");
            Console.WriteLine(forecastCopy);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
           
        }
        var b = Console.ReadLine();
    }

}
