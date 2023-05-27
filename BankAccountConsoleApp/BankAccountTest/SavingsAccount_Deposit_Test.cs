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
    public class SavingsAccount_Deposit_Test
    {
        SavingsAccount _savingsAccount;

        double testBalance = 35;



        public SavingsAccount_Deposit_Test()
        {
            _savingsAccount = new SavingsAccount(testBalance); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 1 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void SavingsDeposit_Is_True_Test()
        {

            // Arrange
            double initialBalance = _savingsAccount.Balance;
            double addedAmount = 5;
            double expectedBalance = 40;

            // Act
            _savingsAccount.Deposit(addedAmount);

            double actualBalance = _savingsAccount.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }

        // Testing Method 1 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void SavingsDeposit_Is_False_Test()
        {

            // Arrange
            double initialBalance = _savingsAccount.Balance;
            double addedAmount = 7;
            double expectedBalance = 40;

            // Act
            _savingsAccount.Deposit(addedAmount);

            double actualBalance = _savingsAccount.Balance;

            // Assert
            Assert.AreNotEqual(expectedBalance, actualBalance);

        }

    }

}