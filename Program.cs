using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace weather
{
	class Program
	{
		static void Main(string[] args)
		{

			string url = "http://api.openweathermap.org/data/2.5/weather?q=Tallinn&units=metric&appid=14b53ebd35439933fcee6c2d32830f60";

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";

			var webResponce = request.GetResponse();
			var webStream = webResponce.GetResponseStream();

			using (var responceReader = new StreamReader(webStream))
			{
				var responce = responceReader.ReadToEnd();
				WeatherDetails.root weather = JsonConvert.DeserializeObject<WeatherDetails.root>(responce);
				Console.WriteLine(weather.name);
				Console.WriteLine(weather.sys.Country);
				Console.WriteLine(weather.Weather[0].Main);
				Console.WriteLine(weather.Weather[0].Description);
				Console.WriteLine(weather.main.Temp);

			}
			
		}
	}
}
