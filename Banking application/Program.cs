using System;

namespace Banking_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a Bank Employee or a Customer?");
            string response = Console.ReadLine();
            if (response == "Bank Employee")
            {
                Console.WriteLine("Log in please");
                string loginEmployee = Console.ReadLine();
                if (loginEmployee == "A1234")
                {
                    Console.WriteLine("Welcome Bank Employee");
                }
                else
                {

                }
            }
            else if(response == "Customer")
            {
                Console.WriteLine("Log in please");
                string loginCustomer = Console.ReadLine();
            }
            else
            {

            }
        }
    }
}
