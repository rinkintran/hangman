using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testLetters
{
    
    
    /// <summary>
    ///This is a test class for lettersTest and is intended
    ///to contain all lettersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class lettersTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for letters Constructor
        ///</summary>
        [TestMethod()]
        public void lettersConstructorTest()
        {
            letters target = new letters();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for contains
        ///</summary>
        /*
        [TestMethod()]
        public void containsTest()
        {
            letters target = new letters(); // TODO: Initialize to an appropriate value
            target.lettersUsed.Append("eeeeee");
            Console.WriteLine(target.lettersUsed);
            char input = 'a'; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.contains(input);
            Assert.AreEqual(expected, actual);
        }
        */
        /// <summary>
        ///A test for getIncorrectGuesses
        ///</summary>
        [TestMethod()]
        public void getIncorrectGuessesTest()
        {
            letters target = new letters(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getIncorrectGuesses();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getLettersUsed
        ///</summary>
        [TestMethod()]
        public void getLettersUsedTest()
        {
            letters target = new letters(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getLettersUsed();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for print
        ///</summary>
        [TestMethod()]
        public void printTest()
        {
            letters target = new letters(); // TODO: Initialize to an appropriate value
            target.print();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for update
        ///</summary>
        [TestMethod()]
        public void updateTest()
        {
            string guessedLetters;
            letters target = new letters(); // TODO: Initialize to an appropriate value
            bool correctGuess = false; // TODO: Initialize to an appropriate value
            char input = 'a'; // TODO: Initialize to an appropriate value
            target.update(correctGuess, input);
            input = 'a'; // TODO: Initialize to an appropriate value
            target.update(correctGuess, input);
            input = 'b'; // TODO: Initialize to an appropriate value
            target.update(correctGuess, input);
            guessedLetters = target.getLettersUsed();
            Assert.AreEqual(guessedLetters,"ab",true);
        }
    }
}
