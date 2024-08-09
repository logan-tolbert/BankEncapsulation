using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Bank
    {
        public Dictionary<int, string>? AccountIdDb { get; set; }
        //List<BankAccount>? AccountsDb { get; set; }
        public string? BankName {  get; set; }
        
        public void Login()
        {
            bool isNumber = false;
            int input;
            Console.WriteLine($"\tWelcome to {BankName}");
            Console.WriteLine("\t--------------------------\n");
            Console.WriteLine("Enter userID:");

            do
            {
                Console.Write(">>> ");
                isNumber = int.TryParse(Console.ReadLine(), out input);
                if (isNumber == true)
                {
                    if (AccountIdDb.ContainsKey(input) == false)
                    {
                        Console.WriteLine("Account does not exist.");
                        isNumber = false;
                       
                    }
                    else
                    {
                        Console.WriteLine($"Hello, {AccountIdDb[input]}.");
                    }               
                }
                else
                {
                    Console.WriteLine("Invalid Input: Please enter a number");
                }

            } while (isNumber == false); 
        }
    }
}
