/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    internal class Encapsula
    {
        class BankAccount
        {
            private string accountNumber;
            private double balance;
            public string AccountNumber
            {
                get { return accountNumber; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        accountNumber = value;
                    }
                    else
                    {
                        throw new ArgumentException("Account number cannot be empty.");
                    }
                }
            }
            public double Balance
            {
                get { return balance; }
                set
                {
                    if (value >= 0)
                    {
                        balance = value;
                    }
                    else
                    {
                        throw new ArgumentException("Balance cannot be negative.");
                    }
                }
            }
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
                else
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }
            }
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                }
                else
                {
                    throw new ArgumentException("Invalid withdrawal amount.");
                }
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Balance: {balance}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                BankAccount account = new BankAccount();
                try
                {
                    account.AccountNumber = "84567861549";
                    account.Balance = 1000.0;
                    account.Deposit(500.0);
                    account.Withdraw(200.0);
                    account.DisplayInfo();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
            }
        }
    }
}
    


*//*class student 
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be empty.");
            }
        }
    }
        public int Age 
        {
            get { return age; }
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be positive.");
                }
            }
        }
    public void DisplayInfo() 
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student Age: {age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        student s = new student();
        try
        {
            s.Name = "Akshay";
            s.Age = 20;
            s.DisplayInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}*/

