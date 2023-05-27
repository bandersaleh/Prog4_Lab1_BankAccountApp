using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConsoleApp
{
    // Abstract keyword is a class and method modifier
    public abstract class Account
    {
        // Field
        double _balance;

        // Constructor
        protected Account(double balance)
        {
            _balance = balance;
        }

        // Methods
        // Property (for _balance) allows the children to set the balance, but restricts other classes
        public double Balance { get => _balance; protected set => _balance = value; } // => is the symbol for Lambda. It's good for writing a quick method that we can delete later that isn't as permanent as method. Lambdas allows us to write an in-line/custom method as seen in our Properties! To use Lambdas we have to use a Delegate. It is used to make code more efficient (Takes up less space than a method, etc...) It's similiar to writing a Function in Javascript.

        //protected abstract void Deposit(double);
        //protected abstract bool Withdraw(double);

    }

}
