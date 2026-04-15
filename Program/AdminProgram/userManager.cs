using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgram
{
    internal class UserManager
    {
            private List<user> users = new List<user>();


            public void AddUser()
            {
                Console.Write("Enter user ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    return;
                }

                if (users.Any(u => u.Id == id))
                {
                    Console.WriteLine("User ID already exists!");
                    return;
                }

                Console.Write("Enter user name: ");
                string name = Console.ReadLine();
                Console.Write("Enter user age: ");
                int age;
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid age");
                    return;
                }
                Console.Write("Enter user E-mail: ");
                string email = Console.ReadLine();
                users.Add(new user(id, name, age, email));
                Console.WriteLine($"User {name} added.");
            }
            public void RemoveUser()
            {
                Console.Write("Enter user ID to remove: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    return;
                }

                var user = users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    users.Remove(user);
                    Console.WriteLine($"User {user.Name} removed.");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }

            public void EditUser()
            {
                Console.Write("Enter user ID to edit: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    return;
                }
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    Console.Write("Enter new name (leave blank to keep current): ");
                    string name = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name))
                    {
                        user.Name = name;
                    }
                    Console.Write("Enter new age (leave blank to keep current); ");
                    string ageInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(ageInput) && int.TryParse(ageInput, out int age))
                    {
                        user.Age = age;
                    }
                    Console.WriteLine($"user {user.Id} updated.");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }

            public void CheckUserAge()
            {
                Console.Write("Enter user ID to check age: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    return;
                }
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    Console.WriteLine($"User {user.Name} is {(user.Age >= 18 ? "an adult" : "a minor")}.");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
                if (user.Age < 18)
                {
                    users.Remove(user);
                }
            }

            public void DisplayUsers()
            {
                if (users.Count == 0)
                {
                    Console.WriteLine("No users in the list.");
                    return;
                }

                Console.WriteLine("\nCurrent Users:");
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}, Email; {user.Email}");
                }
                Console.WriteLine();
            }
        }
    }

