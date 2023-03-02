using Xunit;

namespace Test_3
{
    public class Tests
    {
        [Fact]
        public void TestCapToFront()
        {
            var test1 = Program.CapToFront("moveMENT");
            var test2 = Program.CapToFront("OCAKEshrt");

            Assert.Equal("MENTmove", test1);
            Assert.Equal("OCAKEshrt", test2);
        }
    }
}
