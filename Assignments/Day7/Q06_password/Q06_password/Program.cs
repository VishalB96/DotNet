using System;


namespace Q06_password
{
    class Program
    {
        static bool confirmPassword(string p1, string p2) {

            if (Object.Equals(p1, p2))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
           
                Console.WriteLine("Register : ");
                Console.Write("Username : ");
                string username = Console.ReadLine();
                do
                {
                Console.Write("Enter Password : ");
                string password = Console.ReadLine();
                Console.Write("Confirm password : ");
                string passVer = Console.ReadLine();
                if (confirmPassword(password, passVer))
                {
                    Console.WriteLine("Password confirmed\n{0} Registered successfully!\nExiting....",username);
                    Environment.Exit(0);
                }
                else {
                    Console.WriteLine("Password did not Confirmed!\nDo you want to try again Y/N");
                    char ch = char.Parse(Console.ReadLine());
                    if (ch == 'N'||ch=='n')
                    {
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                    } 
                }
            }
            while (true);
        }
    }
}
