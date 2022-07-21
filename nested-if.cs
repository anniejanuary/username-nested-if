using System;

namespace NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username");
                     
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = ""; //"leaving it empty" -> so when the user writes nothing and clicks enter
                                  //it's treated as empty

            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");

                if (userName != "")
                {
                    Console.WriteLine($"Hi there, {userName}");

                    if(userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
