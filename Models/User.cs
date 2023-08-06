using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagementSystem.Services.Interfaces;

namespace TaskManagementSystem.Models
{
    internal class User
    {
        public Guid Id = Guid.NewGuid();//{ get; set; }
        public string Name { get; set; }
                Regex password = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[A-Za-z\d]{8,}$");
                Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                if (email.IsMatch(value))
                {
                    Email = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                if (password.IsMatch(value))
                {
                    Password = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        
    }
}
