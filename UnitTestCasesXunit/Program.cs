using Xunit;

public class program
{
    static void Main() { }
        [Fact]
        public void ReverseNumberOkTest()
        {
            var expectedValue = 12;
            PracticeCode program = new PracticeCode();

            var result = program.ReverseNumber(21);
            Assert.Equal(expectedValue, result);
            Assert.NotNull(result);
        }
     }