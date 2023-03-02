using System.Text;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that moves all capital letters to the front of a word.

            CapToFront("moveMENT"); //Should return "MENTmove"
        }

        public static string CapToFront(string text)
        {
            StringBuilder stringBuilderUpper = new StringBuilder();
            StringBuilder stringBuilderLower = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    stringBuilderUpper.Append(c);
                }
                else
                {
                    stringBuilderLower.Append(c);
                }
            }

            return stringBuilderUpper.ToString() + stringBuilderLower.ToString();
        }
    }
}
