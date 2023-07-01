using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10000;
            int y = 5;
            int result;

            // TODO: try-catch expressions make error checking easier
            try {
                if (x > 1000) {
                    throw new ArgumentOutOfRangeException("x","x has to be 1000 or less");
                }
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Ikke del på null for faen...");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("x må være 1000 eller under");
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("This code always runs");
            }
        }
    }
}
