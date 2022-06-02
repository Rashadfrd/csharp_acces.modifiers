using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            User user1 = new User(Console.ReadLine());
            Console.WriteLine("Enter password:");
            user1.Password = Console.ReadLine();

            Console.WriteLine($"Name: {user1.UserName}  Password: {user1.Password}");
            

           
        }
    }
}
