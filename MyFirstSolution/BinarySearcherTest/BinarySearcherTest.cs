using BinarySearcher;
namespace BinarySearcherTest
{

    [TestClass]
    public class BinarySearcherTest
    {
        private BinarySearcherAUT _binarySearcher;

        [TestInitialize]
        public void Setup()
        {
            _binarySearcher = new BinarySearcherAUT();
        }
        [TestMethod]
        public void ElementFoundTestWithin()
        {
            /// Arrange - AUT
            int[] input = { 1, 2, 3 };
            int elementtosearch = 2;
            int expectedResult = 1;
            /// Act
            int actual = _binarySearcher.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementFoundTestBeginning()
        {
            /// Arrange - AUT
            int[] input = { 1, 2, 3 };
            int elementtosearch = 1;
            int expectedResult = 0;
            /// Act
            int actual = _binarySearcher.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ElementFoundTestAtEnd()
        {
            /// Arrange - AUT
            int[] input = { 1, 2, 3 };
            int elementtosearch = 3;
            int expectedResult = 2;
            /// Act
            int actual = _binarySearcher.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementNotFoundTestLesser()
        {
            /// Arrange - AUT
            int[] input = { 1, 2, 3 };
            int elementtosearch = 0;
            int expectedResult = ~0; //; Less than 0
            /// Act
            int actual = _binarySearcher.doSearch(input, elementtosearch);
            /// Assert
            Assert.AreEqual(expectedResult, actual);
        }

 
        [TestMethod]
        public void doSearch_ValueFound_ReturnsIndex()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            int valueToFind = 7;

            // Act
            int resultIndex = _binarySearcher.doSearch(sortedArray, valueToFind);

            // Assert
            Assert.AreEqual(3, resultIndex);
        }

        [TestMethod]
        public void doSearch_ValueNotFound_ReturnsNegativeComplement()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            int valueToFind = 6;

            // Act
            int resultIndex = _binarySearcher.doSearch(sortedArray, valueToFind);

            // Assert
            Assert.AreEqual(~3, resultIndex); // ~3 is the bitwise complement of the index 3
        }

        [TestMethod]
        public void doSearch_ValueGreaterThanAllElements_ReturnsNegativeComplement()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            int valueToFind = 10;

            // Act
            int resultIndex = _binarySearcher.doSearch(sortedArray, valueToFind);

            // Assert
            Assert.AreEqual(~5, resultIndex); // ~5 is the bitwise complement of the index 5 
        }

        [TestMethod]
        public void doSearch_ArrayIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            int[] sortedArray = null;
            int valueToFind = 5;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => _binarySearcher.doSearch(sortedArray, valueToFind));
        }

        [TestMethod]
        public void doSearch_EmptyArray_ReturnsNegativeComplement()
        {
            // Arrange
            int[] sortedArray = new int[0];
            int valueToFind = 5;

            // Act
            int resultIndex = _binarySearcher.doSearch(sortedArray, valueToFind);

            // Assert
            Assert.AreEqual(-1, resultIndex); 
        }
    }
}