using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Models
{
    internal class Tasks
    {
        public Guid Id = Guid.NewGuid();//{ get; set; }
        public string Header { get; set; }
        public User Customer { get; set; }
        public User Freelancer { get; set; }
        public Status status { get; set; }
        public enum Status : byte
        {
            pending,
            progress,
            completed
        }

    }
}
