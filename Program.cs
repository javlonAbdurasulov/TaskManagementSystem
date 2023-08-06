using System.Runtime.Serialization;
using System.Xml.Linq;
using TaskManagementSystem.Exceptions;
using TaskManagementSystem.Manager;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services.Classes;

namespace TaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Task - это класс, который представляет задачу. Он может содержать информацию
            //о названии задачи, описании, статусе и других свойствах.

            //-User - это класс, который представляет пользователя.Он может содержать информацию
            //о имени пользователя, адресе электронной почты и других свойствах.

            //-Comment - это класс, который представляет комментарий к задаче.Он может содержать
            //информацию о тексте комментария, дате и времени и других свойствах.

            //-TaskService - это класс, который предоставляет методы для работы с задачами.
            //Он может содержать методы для создания задачи, изменения статуса задачи и других операций.

            //-UserService - это класс, который предоставляет методы для работы с пользователями.
            //Он может содержать методы для создания пользователя, изменения его свойств и других операций.

            //-CommentService - это класс, который предоставляет методы для работы с комментариями.
            //Он может содержать методы для создания комментария, изменения его свойств и других операций.

            try
            {
                Menu();
            }
            catch (Exception e)
            {
                new Exceptions.ExceptionHandler(e).Handle();
            }
            


        }

        public static async Task Menu()
        {
            bool repeat = true;
            UserManager userManager = new UserManager();
            userManager.Run();
            
            while (repeat)
            {
                //Console.WriteLine("vvedite name ili email");
                //string n = Console.ReadLine();
                //Console.WriteLine("vvedite parol");
                //string p = Console.ReadLine();
                //var user = userManager._users.Where(x => (x.Name == n || x.Email == n && x.Password == p)).FirstOrDefault();
                //if (user == null) 
                //{
                //    await Task.Delay(300);
                //    new ExceptionHandler(new Exception());
                //}

                //throw new Exception("nepravilnoye imya ili parol"); 


                Console.WriteLine("Select\n1.Опубликовать задачи\n2.Выполнить задачи");
                byte select = byte.Parse(Console.ReadLine());
                if (select == 1)
                {
                    new TaskManager().Create(userManager.onWork);
                }
                else if (select == 2)
                {
                    new TaskManager().Do(userManager.onWork);
                }
                Console.Clear();
            }
        }
    }
}