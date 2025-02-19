using System;

namespace TaskCompletion
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task("Write a report");
            var notifier = new TaskCompletionNotifier();

            task.TaskCompleted += notifier.OnTaskCompleted;

            task.CompleteTask();
        }
    }
}