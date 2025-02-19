namespace TaskCompletion
{
    public class TaskCompletionNotifier
    {
        public void OnTaskCompleted(string taskName)
        {
            Console.WriteLine($"Task completed: {taskName}");
        }
    }
}