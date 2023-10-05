using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Test
{
    public class ResultTests
    {
        [Fact]
        public void TestGetValue_Success()
        {
            //Arrange
            Result<string> result = new Result<string>("Test");

            //Act
            var value = result.GetValue();

            //Assert
            Assert.Equal("Test", value);
        }

        [Fact]
        public void TestGetValue_Failure()
        {
            //Arrange
            Result<string> result = new Result<string>(new Exception("Test"));

            //Act
            var value = result.GetValue();

            //Assert
            Assert.Equal(default(string), value);
        }

        [Fact]
        public void TestSetValue_Success()
        {
            //Arrange
            Result<int> result = new Result<int>(0);

            //Act
            result.SetValue(10);

            //Assert
            Assert.Equal(10, result.GetValue());
        }

        [Fact]
        public void TestSetValue_Failure()
        {
            //Arrange
            Result<int> result = new Result<int>(new Exception("Test"));

            //Act
            result.SetValue(10);

            //Assert
            Assert.Equal(10, result.GetValue());
        }

        [Fact]
        public void TestIsSuccess_Success()
        {
            //Arrange
            Result<bool> result = new Result<bool>(true);

            //Act
            var isSuccess = result.IsSuccess();

            //Assert
            Assert.True(isSuccess);
        }

        [Fact]
        public void TestIsSuccess_Failure()
        {
            //Arrange
            Result<bool> result = new Result<bool>(new Exception("Test"));

            //Act
            var isSuccess = result.IsSuccess();

            //Assert
            Assert.False(isSuccess);
        }

        [Fact]
        public void TestGetException_Success()
        {
            //Arrange
            Result<string> result = new Result<string>("Test");

            //Act
            var exception = result.GetException();

            //Assert
            Assert.Null(exception);
        }

        [Fact]
        public void TestGetException_Failure()
        {
            //Arrange
            Result<string> result = new Result<string>(new Exception("Test"));

            //Act
            var exception = result.GetException();

            //Assert
            Assert.Equal("Test", exception?.Message);
        }

        [Fact]
        public void TestSetException_Success()
        {
            //Arrange
            Result<int> result = new Result<int>(5);

            //Act
            result.SetException(new Exception("Test"));

            //Assert
            Assert.False(result.IsSuccess());
        }

        [Fact]
        public void TestSetException_Failure()
        {
            //Arrange
            Result<int> result = new Result<int>(new Exception("Test"));

            //Act
            result.SetException(new Exception("New Test"));

            //Assert
            Assert.Equal("New Test", result.GetException()?.Message);
        }
    }
}
