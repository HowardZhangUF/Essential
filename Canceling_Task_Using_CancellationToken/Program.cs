using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        string stars = "*".PadRight(Console.WindowWidth - 1, '*');
        Console.WriteLine("Push ENTER to exit.");

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        Task task = Task.Run(() =>
        {
            WritePi(cancellationTokenSource.Token);
        });

        // Wait for the user's input
        Console.ReadLine();

        cancellationTokenSource.Cancel();
        Console.WriteLine(stars);

        try
        {
            task.Wait();
        }
        catch (AggregateException)
        {
            // Handle any exceptions thrown by the task
        }

        Console.WriteLine();
    }

    private static void WritePi(CancellationToken cancellationToken)
    {
        const int batchSize = 1;
        string piSection = string.Empty;
        int i = 0;

        while (!cancellationToken.IsCancellationRequested || i == int.MaxValue)
        {
            piSection = CalculatePi(6);
            Console.Write(piSection);
        }
    }
    public static string CalculatePi(int precision)
    {
        // Simulating a long-running calculation
       
        return Math.PI.ToString("F" + precision);
    }
}
