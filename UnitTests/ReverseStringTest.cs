using Xunit;

namespace UnitTests
{
    public class ReverseStringTest
    {
        [Fact]
        public void ReverseString_StringInput_ReturnReversedString()
        {
            var input = "He11o Wor!d";

            var result = "dr11o Woe!H";

            var sut = ReverseString.ReverseString.Reverse(input);

            Assert.Equal(result, sut);
        }
    }
}