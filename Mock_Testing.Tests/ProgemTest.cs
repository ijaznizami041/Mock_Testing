using System;
using Xunit;

namespace Mock_Testing.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void Add_WhenInputsAreCorrect_ShouldReturnTrue()
        {
            //Arrange
            Program program = new Program();
            int expected = 7;

            //Act
            int actual = program.Add(3, 4);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
