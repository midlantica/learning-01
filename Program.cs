using System;
using System.Collections.Generic;

namespace bangazon
{
	class Program
	{
		static void Main(string[] args)
		{
		// Dictionary

		// JS
		Dictionary<string, int> toysSold = new Dictionary<string, int>() {
			{"Hot Wheels", 344},
			{"Legos", 763},
			{"Gaming Consoles", 551},
			{"Board Games", 298}
		};

		toysSold.Add("Bicycles", 87);
			foreach(KeyValuePair<string, int> toy in toysSold)
			{
					Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
			}

    }
	}
}

