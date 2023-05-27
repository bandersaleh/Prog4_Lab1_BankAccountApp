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
        CheckingAccount _checkingAccount2;

        double testBalance4 = 35;



        public CheckingAccount_Withdraw_Test()
        {
            _checkingAccount2 = new CheckingAccount(testBalance4); // Initialized a new instance of the class we are testing and gave it a test value for SavingsAccount(double balance) : base(balance)
        }


        // Testing Method 3 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingWithdraw_Is_True_Test()
        {

            // Arrange
            double initialBalance7 = _checkingAccount2.Balance;
            double subtractedAmount7 = 5;
            double expectedBalance7 = 30;

            // Act
            _checkingAccount2.Withdraw(subtractedAmount7);

            double actualBalance7 = _checkingAccount2.Balance;

            // Assert
            Assert.AreEqual(expectedBalance7, actualBalance7);

        }

        // Testing Method 3 SavingsAccount_Deposit_Test
        [TestMethod()]
        public void CheckingWithdraw_Is_False_Test()
        {

            // Arrange
            double initialBalance8 = _checkingAccount2.Balance;
            double subtractedAmount8 = 0;
            double expectedBalance8 = 10;

            // Act
            _checkingAccount2.Withdraw(subtractedAmount8);

            double actualBalance8 = _checkingAccount2.Balance;

            // Assert
            Assert.AreEqual(expectedBalance8, actualBalance8);

        }

    }

}