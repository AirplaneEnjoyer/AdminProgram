using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class mainMenu
    {
        public void Main()
        {
            UserManager manager = new UserManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1 - Add user");
                Console.WriteLine("2 - Remove user");
                Console.WriteLine("3 - Edit user");
                Console.WriteLine("4 - Check user age");
                Console.WriteLine("5 - Display users");
                Console.WriteLine("6 - Exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddUser();
                        break;
                    case "2":
                        manager.RemoveUser();
                        break;
                    case "3":
                        manager.EditUser();
                        break;
                    case "4":
                        manager.CheckUserAge();
                        break;
                    case "5":
                        manager.DisplayUsers();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
