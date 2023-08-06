using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Exceptions;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services.Classes;
using TaskManagementSystem.Services.Interfaces;

namespace TaskManagementSystem.Manager
{
    internal class UserManager
    {
        public List<User> _users = new List<User>();
        public User onWork;
        //{
        //        new User() {Name="Javlon",Email="abdurasulov2203@gmail.com",Password="javayaya1234A"}
        //};
        private readonly IUsersCRUD _userCRUD;

        public UserManager()
        {
            _userCRUD = new UserCRUDService();
            //_users = new List<User>() { 
            //    new User() {Name="Javlon",Email="abdurasulov2203@gmail.com",Password="javayaya1234"}
            //};
        }
        public async Task Run()
        {
            User user = new User() { Name = "Javlon", Email = "abdurasulov2203@gmail.com", Password = "javayaya1234A" };
            _userCRUD.Create(user);
            bool repeat = true;
            while (repeat)
            {

                Console.WriteLine("vvedite name ili email");
                string n = Console.ReadLine();
                Console.WriteLine("vvedite parol");
                string p = Console.ReadLine();
                var users = _users.Where(x => (x.Name == n || x.Email == n && x.Password == p)).FirstOrDefault();
                if (users == null)
                {
                    await Task.Delay(300);
                    new ExceptionHandler(new Exception());
                }
                else
                {
                    repeat = false;
                    onWork = users;
                }

            }
        }
    }
}
