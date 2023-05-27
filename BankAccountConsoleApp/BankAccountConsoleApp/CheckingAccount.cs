using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConsoleApp
{
    public class CheckingAccount : Account // Child class that inherits from Account
    {
        // Field
        double overdraftFee = 25;

        // Constructor
        public CheckingAccount(double balance) : base(balance)
        {
        }



        // Methods
        public override void Deposit(double amount)
        {
            if (amount > 0) //Validate that argument isn't negative
            {
                Balance = Balance + amount; //Add amount to Balance
                //Console.WriteLine("CheckingAccount Deposit Successful!"); // WPF app version: MessageBox.Show("True!");
            }
            else
            {
                Console.WriteLine("CheckingAccount Deposit Failed!"); //WPF app version: MessageBox.Show("False");
            }
        } // Override (Method Modifier)

        public override bool Withdraw(double amount)
        {
            if (amount > 0 || amount < Balance) 
            {
                Balance = Balance - amount;
                return true;
            }
            else
            {
                Balance = Balance - overdraftFee;
                return false;
            }
        } // Override (Method Modifier)
    }
}
