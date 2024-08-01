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
            int actual = aut.doSearch(input, elementtosearch);
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
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectExceptionArgumentNullException() {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[]? input = null;
            int elementtosearch = 4;
            int expectedResult = ~3; //; Less than 0
            /// Act
            int actual = aut.doSearch(input, elementtosearch);
                       
            /// Assert
            // Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void ExpectExceptionRankException()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[,] input = { { 1, 4, 2 }, { 3, 6, 8 } };
            int elementtosearch = 4;
            /// Act
            int actual = aut.doSearch(input, elementtosearch);

            /// Assert
            // Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectArgumentExceptionException()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1,2,3,4,5 };
            string elementtosearch = "one";
            /// Act
            int actual = aut.doSearch(input, elementtosearch);

            /// Assert
            // Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void ExpectRankException()
        {
            /// Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3, 4, 5 };
            string elementtosearch = "one";
            /// Act
            int actual = aut.doSearch(input, elementtosearch);

            /// Assert
            // Assert.AreEqual(expectedResult, actual);
        }


    }
}