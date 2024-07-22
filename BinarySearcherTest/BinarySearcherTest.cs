namespace BinarySearcherTest
{
    [TestClass]
    public class BinarySearcherTest
    {
        [TestMethod]
        public void ElementFoundTest()
        {
            ///Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 2;
            int expectedResult = 1;
            ///Act
            int actual = aut.doSearch(input, elementtosearch);
            ///Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementFoundTestWithin()
        {
            ///Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 2;
            int expectedResult = 1;
            ///Act
            int actual = aut.doSearch(input, elementtosearch);
            ///Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementFoundTestBiginnning()
        {
            ///Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 1;
            int expectedResult = 1;
            ///Act
            int actual = aut.doSearch(input, elementtosearch);
            ///Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ElementFoundTestEnd()
        {
            ///Arrange - AUT
            var aut = new BinarySearcherAUT();
            int[] input = { 1, 2, 3 };
            int elementtosearch = 3;
            int expectedResult = 1;
            ///Act
            int actual = aut.doSearch(input, elementtosearch);
            ///Assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ElementNotFoundTest()
        {

            var aut =new BinarySearcherAUT();
                ///Arrange - AUT <summary>
          
      
                int[] input = { 1, 2, 3 };
                int elementtosearch = 0;
                int expectedResult = 1;
                ///Act
                int actual = aut.doSearch(input, elementtosearch);
                ///Assert
                Assert.AreEqual(expectedResult, actual);
            
            ///Arrange
            ///Act
            ///Assert
        }
        [TestMethod]
        public void ExceptExceptionArgumentNullException()
        {

            var aut = new BinarySearcherAUT();
            ///Arrange - AUT <summary>


            int[] input = null;
            int elementtosearch = 4;
            int expectedResult = 3;
            ///Act
            ///

            try
            {

            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsTrue(true);

            }
            int actual = aut.doSearch(input, elementtosearch);
            ///Assert
            Assert.AreEqual(expectedResult, actual);

            ///Arrange
            ///Act
            ///Assert
        }
        [TestMethod]
        public void ExceptExceptionArgumentRankException()
        {

            var aut = new BinarySearcherAUT();
            ///Arrange - AUT <summary>


            int[] input = { 1, 2, 3 }{ 3,5,7};
            int elementtosearch = 4;
            int expectedResult = 3;
            ///Act
            ///

            try
            {

            }
            catch (ArgumentRankException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsTrue(true);

            }
            int actual = aut.doSearch(input, elementtosearch);
            ///Assert
            Assert.AreEqual(expectedResult, actual);

            ///Arrange
            ///Act
            ///Assert
        }
    }
}