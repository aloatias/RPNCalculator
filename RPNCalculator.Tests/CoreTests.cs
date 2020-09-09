using RpnCalculator.Core;
using Xunit;

namespace RpnCalculator.Tests
{
    public class CoreTests
    {
        private readonly RpnCore _rpnCore;

        public CoreTests()
        {
            _rpnCore = new RpnCore();
        }

        [Fact]
        public void ShouldRespondWithResultEquals4()
        {
            // Prepare
            var entryOperation = "20 5 /";
            var expectedResult = "4";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals3()
        {
            // Prepare
            var entryOperation = "4 2 + 3 -";
            var expectedResult = "3";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals141()
        {
            // Prepare
            var entryOperation = "3 5 8 * 7 + *";
            var expectedResult = "141";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals20()
        {
            // Prepare
            var entryOperation = "2 3 + 4 *";
            var expectedResult = "20";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals40()
        {
            // Prepare
            var entryOperation = "3 5 + 7 2 - *";
            var expectedResult = "40";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals21()
        {
            // Prepare
            var entryOperation = "1 2 + 3 4 + *";
            var expectedResult = "21";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals15()
        {
            // Prepare
            var entryOperation = " 1 2 3 4 + * + ";
            var expectedResult = "15";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals13()
        {
            // Prepare
            var entryOperation = " 1 2 + 3 * 4 + ";
            var expectedResult = "13";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals24()
        {
            // Prepare
            var entryOperation = "4 4 + 5 2 - *";
            var expectedResult = "24";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals5()
        {
            // Prepare
            var entryOperation = "15 7 1 1 + - / 3 * 2 1 1 + + -";
            var expectedResult = "5";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldRespondWithResultEquals7()
        {
            // Prepare
            var entryOperation = "3 4 + 3 2 - *";
            var expectedResult = "7";

            // Act
            string actualResult = _rpnCore.Calculate(entryOperation);

            // Test
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
