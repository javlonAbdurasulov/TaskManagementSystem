using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskManagementSystem.Services.Interfaces
{
    public interface ICRUDBase<T>
    {
        public void Create(T user);
        public void Update(T user,Guid id);
        public void Delete(Guid id);
        public T GetById(Guid id);
        public List<T> GetAll();






    }
}
