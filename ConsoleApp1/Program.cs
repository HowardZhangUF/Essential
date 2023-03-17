using System.Linq;
using System;

public class Program
{
    public static void Main()
    {
        // Data source
        string[] names = { "Ball", "Steve", "James", "Mohan" };

        // LINQ Query 
        var myLinqQuery = from name in names
                          where name.Contains('a')
                          select name;

        // Query execution
        foreach (var name in myLinqQuery)
            Console.WriteLine(name + " ");
            Console.ReadLine();
    }
}



