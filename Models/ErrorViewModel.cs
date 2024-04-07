using SpringFramework.Models;
using System.Collections.Generic;


namespace SpringFramework
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

public class StudentsList
{
    public List<Student> Students { get; set; }

    public StudentsList()
    {
        Students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20 },
            new Student { Name = "Bob", Age = 22 },
            new Student { Name = "Charlie", Age = 21 }
        };
    }
}

