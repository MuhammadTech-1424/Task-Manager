using System;

namespace Task_Manager
{
    public class Vazifa
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public Vazifa(string name, string description = null)
        {
            Name = name;
            Description = description;
            Deadline = DateTime.Now;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        
    }
}