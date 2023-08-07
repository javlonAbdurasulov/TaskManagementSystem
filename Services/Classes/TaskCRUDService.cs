using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services.Interfaces;

namespace TaskManagementSystem.Services.Classes
{
    internal class TaskCRUDService : ITasksCRUD
    {
        public void Create(Tasks user)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tasks GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Task task,Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
