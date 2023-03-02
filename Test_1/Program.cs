namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that returns the selected filename from a path.Include the extension in your answer.

            GetFilename("C:/Projects/pil_tests/ascii/test.txt"); //Should return "test.txt"
        }

        public static string GetFilename(string path)
        {
            var startIndex = path.LastIndexOf("/") + 1;
            string name = path[startIndex..];
            return name;
        }
    }
}
