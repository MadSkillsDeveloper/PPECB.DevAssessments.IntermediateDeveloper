namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes in an array (slot machine outcome) and 
            //returns true if all elements in the array are identical, and false otherwise. The array will contain 4 elements.

            TestJackpot(new string[] { "&&", "&", "&&&", "&&&&" }); //Should return false
        }

        public static bool TestJackpot(string[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int nxtIndex = i == 3 ? i : i + 1;
                if (arr[i] == arr[nxtIndex] &&
                    arr[i].Equals(arr[nxtIndex]))
                {
                    counter++;
                }
                else
                {
                    break;
                }

                if (counter == arr.Length)
                    return true;
            }

            return false;
        }
    }
}
