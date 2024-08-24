using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            const int maxAttempts = 3;
            var loginCounter = 0;
            var username = "soap";
            var password = "1122";


            while (loginCounter < maxAttempts)
            {
                Console.Write("Enter the Username: ");
                username = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Enter the Password: ");
                password = Console.ReadLine();
                Console.Clear();

                if (username == "soap" && password == "1122")
                {

                    Console.WriteLine("You Entered Successfully");
                    break;
                    Console.Clear();
                }
                else
                {
                    loginCounter++;
                    if (loginCounter < maxAttempts)
                    {
                        Console.WriteLine($" Try again. Attempts remaining: {maxAttempts - loginCounter}");

                    }
                }

            }

            var balance = 900;
            var name = username;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Bank Account Name: {name.ToUpper()}");
            Console.WriteLine($"Your Current Balance is: {balance}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1)   Money Deposit");
            Console.WriteLine("2)   Money Withdraw");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("3)   EXIT");

            string options = Console.ReadLine();

            switch (options)
            {
                case "2":
                    Console.WriteLine($"Enter the amount that you want withdraw");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("You are broke dude...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Your Current Balance is: {balance - withdraw}");
                        Console.ReadLine();
                    }
                    break;
                case "1":
                    Console.WriteLine("Enter the amount that you want deposit");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your current Balance is: {balance + deposit} ");
                    break;

                case "3":
                    Console.WriteLine("GTFO");
                    Console.ReadLine();
                    break;
            }


            Console.ReadLine();
        }


    }
}
