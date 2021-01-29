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

            string temp = await GetJSONAsync("Izhevsk");
            Console.WriteLine(temp);
        }
    }
}