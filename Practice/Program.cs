using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            User user1 = new User("Bob", "Smith", 30);        
            User user2 = new User("Darren", "Smith", 50);

            users.Add(user1);
            users.Add(user2);

            foreach(User user in users)
            {
                Console.WriteLine($"First Name: {user._firstName}");
                Console.WriteLine($"Last Name: {user._lastName}");
                Console.WriteLine($"Age: {user._age}");
                Console.WriteLine($"Retired: {user.IsRetired()}");
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }

    }

    
}





