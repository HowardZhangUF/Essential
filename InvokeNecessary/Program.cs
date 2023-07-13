// C# program to illustrate the
// use of 'is' operator keyword
using System;

class Author
{

	// data members
	public string name;
	public int rank;

	// method of Author class
	public void details(string n, int r)
	{
		name = n;
		rank = r;
	}
}

class Work
{

	// data members
	public int articl_no;
	public int improv_no;

	// method of Work class
	public void totalno(int a, int i)
	{
		articl_no = a;
		improv_no = i;
	}
}

// Driver Class
public class GFG
{

	// Main method
	static public void Main()
	{

		// Creating objects of
		// Author and Work class
		Author a = new Author();

		a.details("Ankita", 5);

		Work w = new Work();

		w.totalno(80, 50);

		bool result;

		// Check 'a' is of Author
		// type or not
		// Using is operator
		result = a is Author;
		Console.WriteLine("Is a is Author? : {0}", result);

		// Check w is of Author type
		// using is operator
		result = w is Author;
		Console.WriteLine("Is w is Author? : {0}", result);

		// Take the value of a is null
		a = null;

		// Check null object
		// Using is operator
		result = a is Author;
		Console.WriteLine("Is a is Author? : {0}", result);
		Console.ReadLine();
	}
}
