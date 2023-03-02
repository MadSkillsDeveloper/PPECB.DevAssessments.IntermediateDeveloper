using Xunit;

namespace Test_1
{
    public class Tests
    {
        [Fact]
        public void TestGetFilename()
        {
            var test1 = Program.GetFilename("C:/Projects/pil_tests/ascii/edabit.txt");
            var test2 = Program.GetFilename("ffprobe.exe");

            Assert.Equal("edabit.txt", test1);
            Assert.Equal("ffprobe.exe", test2); 
        }
    }  
}
