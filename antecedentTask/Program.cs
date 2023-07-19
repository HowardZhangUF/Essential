using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Task<string> task = Task.Run(() => CalculatePi(10));

        Task faultedTask = task.ContinueWith(antecedentTask =>
        {
            if (!antecedentTask.IsFaulted)
            {
                throw new Exception("Antecedent Task Should Be Faulted");
            }
            Console.WriteLine("Task State: Faulted");
        }, TaskContinuationOptions.OnlyOnFaulted);

        Task canceledTask = task.ContinueWith(antecedentTask =>
        {
            if (!antecedentTask.IsCanceled)
            {
                throw new Exception("Antecedent Task Should Be Canceled");
            }
            Console.WriteLine("Task State: Canceled");
        }, TaskContinuationOptions.OnlyOnCanceled);

        Task completedTask = task.ContinueWith(antecedentTask =>
        {
            if (!antecedentTask.IsCompleted)
            {
                throw new Exception("Antecedent Task Should Be Completed");
            }
            Console.WriteLine("Task State: Completed");
        }, TaskContinuationOptions.OnlyOnRanToCompletion);

        completedTask.Wait();
    }

    public static string CalculatePi(int precision)
    {
        // Simulating a long-running calculation
        Task.Delay(1000).Wait();
        return Math.PI.ToString("F" + precision);
    }
}
