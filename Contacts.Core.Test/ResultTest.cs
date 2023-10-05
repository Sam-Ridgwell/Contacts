namespace Contacts.Core.Test
{
    public class ResultTests
    {
        [Fact]
        public void TestGetValue_Success()
        {
            //Arrange
            var result = new Result<string>("Test");

            //Act
            var value = result.GetValue();

            //Assert
            Assert.Equal("Test", value);
        }

        [Fact]
        public void TestGetValue_Failure()
        {
            //Arrange
            var result = new Result<string>(new Exception("Test"));

            //Act
            var value = result.GetValue();

            //Assert
            Assert.Null(value);
        }

        [Fact]
        public void TestIsSuccess_Success()
        {
            //Arrange
            var result = new Result<bool>(true);

            //Act
            var isSuccess = result.IsSuccess();

            //Assert
            Assert.True(isSuccess);
        }

        [Fact]
        public void TestIsSuccess_Failure()
        {
            //Arrange
            var result = new Result<bool>(new Exception("Test"));

            //Act
            var isSuccess = result.IsSuccess();

            //Assert
            Assert.False(isSuccess);
        }

        [Fact]
        public void TestGetException_Success()
        {
            //Arrange
            var result = new Result<string>("Test");

            //Act
            var exception = result.GetException();

            //Assert
            Assert.Null(exception);
        }

        [Fact]
        public void TestGetException_Failure()
        {
            //Arrange
            var result = new Result<string>(new Exception("Test"));

            //Act
            var exception = result.GetException();

            //Assert
            Assert.Equal("Test", exception?.Message);
        }
    }
}
