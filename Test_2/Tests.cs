using Xunit;

namespace Test_2
{
    public class Tests
    {
        [Fact]
        public void TestTestJackpot()
        {
            var test1 = Program.TestJackpot(new string[] { "SS", "SS", "SS", "Ss" });
            var test2 = Program.TestJackpot(new string[] { "SS", "SS", "SS", "SS" });

            Assert.False(test1);
            Assert.True(test2);
        }
    }
}