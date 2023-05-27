using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTest
{
    [TestClass()]
    public class CheckingAccount_Withdraw_Test
    {
        CheckingAccount _checkingAccount;

        double testBalance = 35;



        public CheckingAccount_Withdraw_Test()
        {
            _checkingAccount = new CheckingAccount(testBalance); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 4 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingWithdraw_Is_True_Test()
        {

            // Arrange
            double initialBalance = _checkingAccount.Balance;
            double subtractedAmount = 5;
            double expectedBalance = 30;

            // Act
            _checkingAccount.Withdraw(subtractedAmount);

            double actualBalance = _checkingAccount.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }

        // Testing Method 4 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingWithdraw_Is_False_Test()
        {

            // Arrange
            double initialBalance = _checkingAccount.Balance;
            double subtractedAmount = 0;
            double expectedBalance = 10;

            // Act
            _checkingAccount.Withdraw(subtractedAmount);

            double actualBalance = _checkingAccount.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }

    }

}