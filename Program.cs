﻿using System;
using System.Collections.Generic;

namespace bangazon
{
	class Program
	{
	static void Main(string[] args)
	{
		// DateTime is the type of the purchaseData variable.
		DateTime purchaseDate=DateTime.Now;

		/*
		string is the type of the lastName variable. It
		tells the compiler that the lastName variable can
		ONLY hold a string value.
		*/
		string lastName="Smith";

		/*
		C# now supports implicitly typing of a variable. The
		type of the variable will be determined, by the
		compiler, at compile time.
		*/
		var firstName="Bill";

		/*
		String interpolation in C# is similar to string interpolation in JavaScript,
		but there is a different syntax.

		An equivalent statement in JavaScript would be:
		console.log(`${firstName} ${lastName} purchased on ${purchaseDate}`);
		*/
		Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");
	}
	}
}
