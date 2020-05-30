using System;
using System.Collections.Generic;

namespace bangazon
{
	class Program
	{
		static void Main(string[] args)
		{
			// DateTime is the type of the purchaseData variable.
			DateTime purchaseDate=DateTime.Now;
			// string lastName="Smith";
			// var firstName="Bill";

			// Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");

			List<string> products = new List<string>() {
        "Motorcycle",
        "Sofa",
        "Sandals",
        "Omega Watch",
        "iPhone"
      };

      // foreach (string product in products) {
      //   Console.WriteLine(product);
      // };

      // Console.WriteLine("#########");

      // for (int i=0; i<products.Count; i++) {
      //   Console.WriteLine(products[i]);
      // }

      // foreach(string product in products){
      //   if(product.Length < 5){
      //     Console.WriteLine($"{product} has a short name.");
      //   } else if (product.Length < 10) {
      //     Console.WriteLine($"{product} has a medium-sized name.");
      //   } else {
      //     Console.WriteLine($"{product} has a long name.");
      //   }
      // }

      // >>>>>>>>>>>

      List<string> students = new List<string>() {
        "Megan", "Damon", "Chase", "Tekisha",
        "Castle", "Mark", "Keith", "Adam",
        "Patrick", "Hannah", "Mike"
      };

      // Can't do this easily with a base array
      students.Add("Melanie");
      students.Insert(3, "Simon");

      // if (students.Contains("Chase")) {
      //   Console.WriteLine("Must be cohort 13");
      // }

      // This looks a lot like JavaScript!
      // students.ForEach(x => Console.WriteLine(x));

      // >>>>>>>>>>>>
      List<int> yearsBorn = new List<int>() {
        1967, 1969, 1972
      };

      // Console.WriteLine(string.Join(", ", yearsBorn));

      // foreach (int x in yearsBorn)
      // {
      //   Console.WriteLine(x);
      // }

      // >>>>>>>>>>>
      int[] itemsSold = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      // Console.WriteLine(string.Join(", ", itemsSold));

      // >>>>>>>
      List<string> planetList = new List<string>(){"Mercury", "Mars"};
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      List<string> planetLast = new List<string>(){"Uranus", "Neptune"};
      planetList.AddRange(planetLast);
      Console.WriteLine("---------------\nPlanets:");
      Console.WriteLine((string.Join(", ", planetList)) + ".");

      List<string> venusEarth = new List<string>() { "Venus", "Earth" };
      planetList.InsertRange(1, venusEarth);
      Console.WriteLine("---------------\nMissing planets added:");
      Console.WriteLine((string.Join(", ", planetList)) + ".");

      planetList.Add("Pluto");
      Console.WriteLine("---------------\nPluto added:");
      Console.WriteLine((string.Join(", ", planetList)) + ".");

      List<string> rockyPlanets = new List<string>() { };
      rockyPlanets = planetList.GetRange(0,4);
      Console.WriteLine("---------------\nRocky planets separated out:");
      Console.WriteLine((string.Join(", ", rockyPlanets)) + ".");

    }
	}
}

