using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           BankAccount Account1 = new BankAccount();

            Console.WriteLine($"How much would you like to deposit into your account?");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            Account1.Deposit(depositAmount);
            double userBalance = Account1.GetBalance();

            Console.WriteLine($"Your balance is: {userBalance, 0:c}");

        }

                
                
            

        
    }
}