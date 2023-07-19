using System;
using System.Threading.Tasks;

public static class Program
{
    public static void Main()
    {
        Task task = Task.Run(() =>
        {
            throw new InvalidOperationException();
        });

        try
        {
            task.Wait();
        }
        catch (AggregateException exception)
        {
            foreach (var innerException in exception.InnerExceptions)
            {
                Console.WriteLine($"ERROR: {innerException.Message}");
                Console.ReadLine();
            }
        }
    }
}

