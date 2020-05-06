using System;
using System.Collections.Generic;

namespace Onibode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.doSomething();
        }

        public void doSomething()
        {
            List<string> firstNames = new List<string>() {"Iyaami", "Ogun", "Ifa"};
            List<string> lastNames = new List<string>() {"Orunmilla", "Esu", "Sango"};

            List<User> users = new List<User>();

            for (int i = 0; i < firstNames.Count; i++)
            {
                User user = new User();
                user.FirstName = firstNames[i];
                user.LastName = lastNames[i];
                users.Add(user);
            }
            
            User me = new User();
            me.FirstName = "King";
            me.LastName = "Solomon";

            User you = new User();
            you.FirstName = "Sub";
            you.LastName = "Sandwich";

            foreach (User usr in users)
            {
                Console.WriteLine(usr.FullName);
            }

            takeUser(users[0]);
        }

        public void takeUser(User user)
        {
            Console.WriteLine(user.FullName);
        }
    }
}