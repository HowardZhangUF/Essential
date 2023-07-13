using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		var cities = new Dictionary<string, string>(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

		cities["UK"] = "Liverpool, Bristol"; // update value of UK key
		cities["USA"] = "Los Angeles, Boston"; // update value of USA key
											   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

		if (cities.ContainsKey("France"))
		{
			cities["France"] = "Paris";
		}

		foreach (var kvp in cities)
			Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
		Console.ReadLine();
	}
}