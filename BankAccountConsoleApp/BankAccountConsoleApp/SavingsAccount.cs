using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConsoleApp
{
    public class SavingsAccount : Account // Child class that inherits from Account
    {
        // Field
        //double _amount; // Temporary value to test the app's functionality


        // Constructor
        public SavingsAccount(double balance) : base(balance)
        {
        }




        // Properties
        //public double amount { get => _amount; set => _amount = value; }



        // Methods
        protected override void Deposit(double amount)
        {
            if (amount > 0) //Validate that argument isn't negative
            {
                Balance = Balance + amount; //Add amount to Balance
                Console.WriteLine("SavingsAccount Deposit Successful!"); // WPF app version: MessageBox.Show("True!");
            }
            else
            {
                Console.WriteLine("SavingsAccount Deposit Failed!"); //WPF app version: MessageBox.Show("False");
            }

        } // Override (Method Modifier)

        protected override bool Withdraw(double amount)
        {
            if (amount > 0 && amount < Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            else
            {
                return false;
            }
        } // Override (Method Modifier)
    }

}
