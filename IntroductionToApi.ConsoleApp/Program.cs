using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionToApi.ConsoleApp.Models;
using Newtonsoft.Json;

namespace IntroductionToApi.ConsoleApp
{
	class Program{
		static void Main(string[] args)
		{
			HttpClient httpClient = new HttpClient();

			HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;

			if (response.IsSuccessStatusCode)
			{
				var content = response.Content.ReadAsStringAsync().Result; 
				var person = JsonConvert.DeserializeObject<Person>(content);

				Person luke = response.Content.ReadAsAsync<Person>().Result;
				Console.WriteLine(luke.Name);

				// foreach(string vehiclesUrl in luke.Vehicles)
				// {

				// }
			}
		}	
	}
}