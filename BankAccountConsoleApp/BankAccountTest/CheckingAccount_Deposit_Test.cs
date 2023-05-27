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
        CheckingAccount _checkingAccount1;

        double testBalance3 = 35;



        public CheckingAccount_Deposit_Test()
        {
            _checkingAccount1 = new CheckingAccount(testBalance3); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 3 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingDeposit_Is_True_Test()
        {

            // Arrange
            double initialBalance5 = _checkingAccount1.Balance;
            double addedAmount5 = 5;
            double expectedBalance5 = 40;

            // Act
            _checkingAccount1.Deposit(addedAmount5);

            double actualBalance5 = _checkingAccount1.Balance;

            // Assert
            Assert.AreEqual(expectedBalance5, actualBalance5);

        }

        // Testing Method 3 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingDeposit_Is_False_Test()
        {

            // Arrange
            double initialBalance6 = _checkingAccount1.Balance;
            double addedAmount6 = 7;
            double expectedBalance6 = 40;

            // Act
            _checkingAccount1.Deposit(addedAmount6);

            double actualBalance6 = _checkingAccount1.Balance;

            // Assert
            Assert.AreNotEqual(expectedBalance6, actualBalance6);

        }

    }

}