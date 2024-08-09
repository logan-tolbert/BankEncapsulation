namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var myBank = new Bank();
            myBank.BankName = "Bank of Kilgore";
            myBank.AccountIdDb = new Dictionary<int, string>()
            { 
                { 42, "Logan" }
            };

            var myAccount = new BankAccount();
            bool endProgram = false;
            double depositAmount = 0.00;

            myBank.Login();
            

            do
            {
                bool isNumber = false;
                int input;

                Console.WriteLine("-------------------------------");
                Console.WriteLine("\t1) Check balance");
                Console.WriteLine("\t2) Deposit");
                Console.WriteLine("\t3) Quit");
                Console.WriteLine("-------------------------------\n");
                Console.Write(">>> ");

                do
                {
                    isNumber = int.TryParse(Console.ReadLine(), out input);
                    if (isNumber == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input: Please enter a number\n");
                    }

                } while (isNumber == false);


                Console.Clear();


                if (input == 1)
                {
                    Console.WriteLine($"\nCurrent balance: ${myAccount.GetBalance()}");
                 
                }
                else if (input == 2)
                {
                    Console.Write("Enter deposit amount: $");

                    bool isDepositAmountNumber = false;
                    do
                    {
                        isDepositAmountNumber = double.TryParse(Console.ReadLine(), out depositAmount);
                        if (isNumber == true)
                        {
                            myAccount.Deposit(depositAmount);

                            Console.WriteLine($"New balance: ${myAccount.GetBalance()}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input: Please enter a number\n");
                        }

                    } while (isDepositAmountNumber == false);

                }
                else if (input == 3)
                {
                    endProgram = true;
                } 
            } while (endProgram == false);

            Console.WriteLine($"Thank you for banking with {myBank.BankName}.");
            Console.WriteLine("\tHave a great day!");


        }
    }
}
