/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    public class Bank_Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Bank_Account(string accountNumber, decimal initialbalance)
        {
                AccountNumber = accountNumber;
                Balance = initialbalance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} Updated {Balance}");
        }
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw amount {amount} : Available {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

    }

    public class Saving_Account : Bank_Account
    {
        public decimal InterestRate { get; set; }
        public Saving_Account(string accountNumber, decimal initialBalance, decimal interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest added: {interest}. New Balance: {Balance}");
        }

    }
    class Program 
    {
        static void Main() { 

            string ac;
            do
            {
                Console.Write("Enter Account Number (10 digits): ");
                ac = Console.ReadLine();

                if (ac.Length != 10 || !ac.All(char.IsDigit))
                {
                    Console.WriteLine("Invalid Account Number. It must be exactly 10 digits.");
                }

            } while (ac.Length != 10 || !ac.All(char.IsDigit)); 

            Console.Write("Enter Initial Balance: ");
            decimal ib = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Interest Rate: ");
            decimal intr = Convert.ToDecimal(Console.ReadLine());

            Saving_Account saving = new Saving_Account(ac, ib, intr);

            Console.Write("Enter Deposit Amount: ");
            decimal nm = Convert.ToDecimal(Console.ReadLine());
            saving.Deposit(nm);

            Console.Write("Enter Withdraw Amount: ");
            decimal wm = Convert.ToDecimal(Console.ReadLine());
            saving.Withdraw(wm);

            saving.AddInterest();
        }
        //{
        //    String ac;
        //    do
        //    {
        //        Console.Write("Enter Account Number : ");
        //        String ac = Console.ReadLine();
        //        if (ac.Length != 10)
        //        {
        //            Console.Write("Invaid account number");
        //        }
        //    } while (ac.Length != 10);
        //        Console.Write("Enter Initial Balance : ");
        //        decimal ib = Convert.ToDecimal(Console.ReadLine());
        //        Console.Write("Enter Intrest rate : ");
        //        decimal intr = Convert.ToDecimal(Console.ReadLine());
        //        Saving_Account saving = new Saving_Account(ac, ib, intr);

        //        Console.Write("Enter Deposite Amount");
        //        decimal nm = Convert.ToDecimal(Console.ReadLine());
        //        saving.Deposit(nm);

        //        Console.Write("Enter Withdraw Amount");
        //        decimal wm = Convert.ToDecimal(Console.ReadLine());
        //        saving.Withdraw(wm);
        //        saving.AddInterest();
        //             }
        //}    
    }
}
*/