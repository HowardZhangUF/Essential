using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
		// Student collection
		IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
			};

		var orderByResult = from s in studentList
							orderby s.StudentName //Sorts the studentList collection in ascending order
							select s;

		var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
									  orderby s.StudentName descending
									  select s;

		Console.WriteLine("Ascending Order:");

		foreach (var std in orderByResult)
			Console.WriteLine(std.StudentName);

		Console.WriteLine("Descending Order:");

		foreach (var std in orderByDescendingResult)
			Console.WriteLine(std.StudentName);
		Console.ReadLine();

	}

}

public class Student
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}