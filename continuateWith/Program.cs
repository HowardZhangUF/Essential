using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Create a Task that performs some computation
        Task<int> computationTask = Task.Run(() => Compute());

        // Use ContinueWith to chain another task that executes when the computationTask is completed
        Task<string> resultTask = computationTask.ContinueWith(task => ProcessResult(task.Result));

        // ContinueWith returns a new Task representing the result of the continuation
        // We can then use this task to perform further operations or await its completion
        resultTask.ContinueWith(task =>
        {
            Console.WriteLine("Final result: " + task.Result);
        });

        // Wait for the final task to complete (optional)
        resultTask.Wait();

        Console.ReadLine();
    }

    static int Compute()
    {
        // Simulate some time-consuming computation
        Console.WriteLine("Performing computation...");
        Task.Delay(2000).Wait();
        return 42;
    }

    static string ProcessResult(int result)
    {
        // Perform some processing on the computed result
        Console.WriteLine("Processing result...");
        return "Processed: " + result;
    }
}
