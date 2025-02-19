using System;

namespace TaskCompletion
{
    public class Task
    {
        public event Action<string> TaskCompleted;

        public string Name { get; private set; }

        public Task(string name)
        {
            Name = name;
        }

        public void CompleteTask()
        {
            OnTaskCompleted(Name);
        }

        protected virtual void OnTaskCompleted(string taskName)
        {
            TaskCompleted?.Invoke(taskName);
        }
    }
}