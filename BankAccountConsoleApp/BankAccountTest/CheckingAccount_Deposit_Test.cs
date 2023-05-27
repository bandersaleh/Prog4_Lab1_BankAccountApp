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
    public class CheckingAccount_Deposit_Test
    {
        CheckingAccount _checkingAccount;

        double testBalance = 35;



        public CheckingAccount_Deposit_Test()
        {
            _checkingAccount = new CheckingAccount(testBalance); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 3 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingDeposit_Is_True_Test()
        {

            // Arrange
            double initialBalance = _checkingAccount.Balance;
            double addedAmount = 5;
            double expectedBalance = 40;

            // Act
            _checkingAccount.Deposit(addedAmount);

            double actualBalance = _checkingAccount.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }

        // Testing Method 3 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingDeposit_Is_False_Test()
        {

            // Arrange
            double initialBalance = _checkingAccount.Balance;
            double addedAmount = 7;
            double expectedBalance = 40;

            // Act
            _checkingAccount.Deposit(addedAmount);

            double actualBalance = _checkingAccount.Balance;

            // Assert
            Assert.AreNotEqual(expectedBalance, actualBalance);

        }

    }

}