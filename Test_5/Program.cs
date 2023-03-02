using System;

namespace Test_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two functions ToCamelCase() and ToSnakeCase() that each take a single string 
            //and convert it into either camelCase or snake_case.

            ToCamelCase("hello_edabit"); //Should return "helloEdabit"

            ToSnakeCase("helloEdabit"); //Should "hello_edabit"

            ToCamelCase("is_modal_open"); //Should return "isModalOpen"

            ToSnakeCase("getColor"); //Should "get_color"
        }

        public static string ToSnakeCase(string str)
        {
            throw new NotImplementedException();
        }

        public static string ToCamelCase(string str)
        {
            throw new NotImplementedException();
        }
    }
}
