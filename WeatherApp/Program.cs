using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        public static async Task<string> GetJSONAsync(string city)
        {
            const string APPID = "d1ea1139add1f36ed5b4f45e9e9e6c2b";

            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=" + APPID;

            WebRequest request = WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";
            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }

            response.Close();

            return answer;
        }

        static async Task Main(string[] args)
        {

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            Console.WriteLine("\n=========================================================\n");

            try
            {
                string answer = await GetJSONAsync(city);

                Console.WriteLine(answer);

                Console.WriteLine("\n=========================================================\n");

                OpenWeather ow = JsonConvert.DeserializeObject<OpenWeather>(answer);

                Console.WriteLine($"Город:\t\t\t {ow.name}");
                Console.WriteLine($"Осадки: \t\t {ow.weather[0].main}");
                Console.WriteLine($"Описание:\t\t {ow.weather[0].description}");
                Console.WriteLine($"Средняя температура:\t {ow.main.Temp.ToString("0.##")}");
                Console.WriteLine($"Скорость ветра:\t\t {ow.wind.speed} м/с");
                Console.WriteLine($"Направление ветра:\t {ow.wind.deg}");
                Console.WriteLine($"Влажность:\t\t {ow.main.humidity} %");
                Console.WriteLine($"Давление:\t\t {((int)ow.main.Pressure)} мм рт.ст.");

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Кажется, произошла ошибка. Возможно, название города набрано с ошибкой.\n");
                Console.WriteLine(e.Message);
            }
        }
    }
}