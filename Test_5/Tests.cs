using Xunit;

namespace Test_5
{
    public class Tests
    {
        [Fact]
        public void TestToCamelCase()
        {
            var test1 = Program.ToCamelCase("hello_edabit");
            var test2 = Program.ToCamelCase("is_modal_open");
             
            Assert.Equal("helloEdabit", test1);
            Assert.Equal("isModalOpen", test2);
        }

        [Fact]
        public void TestToSnakeCase()
        {
            var test1 = Program.ToSnakeCase("getColor");
            var test2 = Program.ToSnakeCase("helloEdabit");

            Assert.Equal("get_color", test1);
            Assert.Equal("hello_edabit", test2);
        }
    }
}
