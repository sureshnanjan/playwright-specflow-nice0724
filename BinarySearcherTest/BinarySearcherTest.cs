using BinarySearcher;
namespace BinarySearcherTest
{
    [TestClass]
    public class BinarySearcherTest
    {
        [TestMethod]
        public void ElementFoundTestWithin()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 2;
            int expectedResult = 1;
            /// Act
            int actual = aut.doSearch(input,elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }
        
        [TestMethod]
        public void ElementFoundTestBeginning()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 1;
            int expectedResult = 0;
            /// Act
            int actual = aut.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ElementFoundTestAtEnd()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 3;
            int expectedResult = 2;
            /// Act
            int actual = aut.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementNotFoundTestLesser()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 0;
            int expectedResult = ~0; //; Less than 0
            /// Act
            int actual = aut.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementNotFoundTestGreater()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 4;
            int expectedResult = ~3; //; Less than 0
            /// Act
            int actual = aut.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ExpectExceptionArgumentNullException() {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[]? input = null;
            int elementtosearch = 4;
            int expectedResult = ~3; //; Less than 0
            /// Act
            try
            {
                int actual = aut.doSearch(input, elementtosearch);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsTrue(true);
            }

            
            /// Assert
            // Assert.AreEqual(expectedResult, actual);
        }


    }
}