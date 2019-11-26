using System;
using System.Collections.Generic;

namespace TaskListRevisited.Models
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public string Details { get; set; }
        public DateTime DueDate { get; set; }
        public bool? Completion { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
