using System;

namespace KallDetHvaDuVil
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brOwn fox jumps over the lazy dog";

            // TODO: the basic for loop
            // Console.WriteLine("The basic for loop:");
            // for (int i=0; i < myVal; i++) {
            //     Console.WriteLine($"i is currentlyh {i}");
            // }

            // Console.WriteLine();

            // TODO: the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The foreach loop:");
            int count = 0;
            foreach(char c in str) {
                if (c == 'o' || c=='O') {
                    count++;
                }
            }
            Console.WriteLine("There are {0} o's in the variable str",count);


            // TODO: count the number of o's in the string

        }
    }
}
