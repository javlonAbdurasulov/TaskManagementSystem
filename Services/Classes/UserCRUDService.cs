using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services.Interfaces;

namespace TaskManagementSystem.Services.Classes
{
    internal class UserCRUDService : IUsersCRUD
    {
        private List<User> _users;
        public void Create(User user)
        {
            _users.Add(user);
        }

        public void Delete(Guid id)
        {
            var RemoveUser = _users.Where(x => x.Id == id).FirstOrDefault();
            _users.Remove(RemoveUser);
        }

        public List<User> GetAll()
        {
            return _users;

        }

        public User GetById(Guid id)
        {
            return  _users.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(User user,Guid id)
        {
            var UpdateUser = _users.Where(x => x.Id == id).FirstOrDefault();
            _users[_users.IndexOf(UpdateUser)] =user;
        }
    }
}
