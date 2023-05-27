namespace BankAccountTest
{
    [TestClass]
    public class UnitTest1
    {
        // Data Attributes
        [TestMethod]
        public void TestMethod1()
        {
            // begin with the UnitTesting routine: AAA (Arrange, Act, Assert)

            // Arrange
            // Arrange inputs and targets. Arrange steps should set up the test case. Does the test require any objects or special settings? Does it need to prep a database? Does it need to log into a web app? Handle all of these operations at the start of the test.

            // Act
            // Act on the target behavior.Act steps should cover the main thing to be tested. This could be calling a function or method, calling a REST API, or interacting with a web page. Keep actions focused on the target behavior.

            // Assert
            // Assert expected outcomes.Act steps should elicit some sort of response. Assert steps verify the goodness or badness of that response. Sometimes, assertions are as simple as checking numeric or string values. Other times, they may require checking multiple facets of a system. Assertions will ultimately determine if the test passes or fails.


            //Assert.IsTrue(false, "The method was false"); // Our 1st Test
            Assert.IsTrue(true); // Our 2nd Test


        } // Method - Initial/Default Test Method



        
    }
}