using System;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that swaps the first pair (1st and 2nd characters) with the second pair
            // (3rd and 4th characters) for every quadruplet substring.

            SwapTwo("ABCDEFGH"); //Should return "CDABGHEF"

        }

        public static string SwapTwo(string text)
        {
            Tuple<char, char> firstPair;
            Tuple<char, char> secondPair;
            int devisor = 2;

            for (int i = 0; i < text.Length; i++)
            {
                firstPair = Tuple.Create(text[i], text[i + 1]);

                if (i % devisor == 0)
                    secondPair = Tuple.Create(text[i], text[i + 1]);
            }

            return string.Empty;
        }
    }
}
