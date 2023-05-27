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
    public class SavingsAccount_Withdraw_Test
    {
        SavingsAccount _savingsAccount2;

        double testBalance2 = 35;



        public SavingsAccount_Withdraw_Test()
        {
            _savingsAccount2 = new SavingsAccount(testBalance2); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 2 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void SavingsWithdraw_Is_True_Test()
        {

            // Arrange
            double initialBalance3 = _savingsAccount2.Balance;
            double subtractedAmount3 = 5;
            double expectedBalance3 = 30;

            // Act
            _savingsAccount2.Withdraw(subtractedAmount3);

            double actualBalance3 = _savingsAccount2.Balance;

            // Assert
            Assert.AreEqual(expectedBalance3, actualBalance3);

        }

        // Testing Method 2 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void SavingsWithdraw_Is_False_Test()
        {

            // Arrange
            double initialBalance4 = _savingsAccount2.Balance;
            double addedAmount4 = 5;
            double expectedBalance4 = 21;

            // Act
            _savingsAccount2.Deposit(addedAmount4);

            double actualBalance4 = _savingsAccount2.Balance;

            // Assert
            Assert.AreNotEqual(expectedBalance4, actualBalance4);

        }

    }

}