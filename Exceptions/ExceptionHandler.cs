using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Exceptions
{
    internal class ExceptionHandler
    {
        private string _exception { get; set; }
        
        public ExceptionHandler(Exception e)
        {

            _exception = e.Message;
        }

        public void Handle()
        {
            Console.WriteLine("Exception: "+_exception);
        }

    }
}
