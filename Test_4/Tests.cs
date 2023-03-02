using Xunit;

namespace Test_4
{
    public class Tests
    {
        [Fact]
        public void TestSwapTwo()
        {
            var test1 = Program.SwapTwo("FFGGHHI");
            var test2 = Program.SwapTwo("AABBCCDDEEFF");
             
            Assert.Equal("GGFFHHI", test1);
            Assert.Equal("BBAADDCCFFEE", test2);
        }
    }
}
