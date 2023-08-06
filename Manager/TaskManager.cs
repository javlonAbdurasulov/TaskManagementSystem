using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services.Classes;
using TaskManagementSystem.Services.Interfaces;

namespace TaskManagementSystem.Manager
{
    internal class TaskManager
    {
        
        private readonly ITasksCRUD _taskCRUD;
        public TaskManager()
        {
            _taskCRUD = new TaskCRUDService();
            
        }
        public void Create(User obj)
        {
            Tasks tasks = new Tasks();
            Console.WriteLine("Введите заголовок:\n");
            tasks.Header = Console.ReadLine();
            tasks.Customer = obj;
            tasks.status = Tasks.Status.pending;
            Console.WriteLine();
        }
        public void Do(User obj)
        {
            List<Tasks> tasks = _taskCRUD.GetAll();

            

        }
    }
}
