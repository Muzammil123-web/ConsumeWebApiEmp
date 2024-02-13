using Xunit;
using PracticeOnDigits;

namespace TestProjectOnCode
{
    public class PracticeCodeOnCodeTesting
    {
        [Fact]
        public void ReverseNumberTestOk()
        {
            int expectedValue = 321;
            PracticeCode code = new PracticeCode();
           var results= code.ReverseNumber(123);
            Assert.Equal(expectedValue, results);
            
        }
    }
}