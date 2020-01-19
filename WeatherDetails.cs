using System;
using System.Collections.Generic;
using System.Text;

namespace weather
{
	class WeatherDetails
	{

		public class Main
		{
			public double Temp { get; set; }			
		}

		public class Weather
		{
			public string Main { get; set; }
			public string Description { get; set; }
			
		}

		public class Sys
		{
			public string Country { get; set; }
		}

		public class root
		{
			public Sys sys { get; set; }
			public List<Weather>Weather { get; set; }
			public string name { get; set; }
			public Main main { get; set; }
		}

	}
}
