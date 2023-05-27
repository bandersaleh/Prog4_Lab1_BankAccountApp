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
        SavingsAccount _savingsAccount1;

        double testBalance1 = 35;



        public SavingsAccount_Deposit_Test()
        {
            _savingsAccount1 = new SavingsAccount(testBalance1); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 1 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void SavingsDeposit_Is_True_Test()
        {

            // Arrange
            double initialBalance1 = _savingsAccount1.Balance;
            double addedAmount1 = 5;
            double expectedBalance1 = 40;

            // Act
            _savingsAccount1.Deposit(addedAmount1);

            double actualBalance1 = _savingsAccount1.Balance;

            // Assert
            Assert.AreEqual(expectedBalance1, actualBalance1);

        }

        // Testing Method 1 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void SavingsDeposit_Is_False_Test()
        {

            // Arrange
            double initialBalance2 = _savingsAccount1.Balance;
            double addedAmount2 = 7;
            double expectedBalance2 = 40;

            // Act
            _savingsAccount1.Deposit(addedAmount2);

            double actualBalance2 = _savingsAccount1.Balance;

            // Assert
            Assert.AreNotEqual(expectedBalance2, actualBalance2);

        }

    }

}