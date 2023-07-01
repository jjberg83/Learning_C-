using System;

namespace RefAndOutParams {
    class Program {
        // TODO: Ordinary value arguments cannot be modified by the function
        // because they are a copy of the original value
        static void TestFunc1(int arg1) {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        // TODO: Arguments that are passed by reference can be modified
        // by the function and reflected back to the caller
        // Mao, setter vi ref foran både her og i funksjonskallet, endres
        // verdi for den globale variabelen også, ikke bare lokalt 
        // inni funksjonen.
        static void TestFunc2(ref int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }


        // TODO: The "out" keyword means that the parameter returns a value and is not
        // used to supply data to the function
        static void TestFunc3(int arg1, int arg2, out int summen, out int produktet) {
            summen = arg1 + arg2;
            produktet = arg1 * arg2;
        } 

        static void Main(string[] args) {
            int val1 = 10;
            int val2 = 20;

            // Functions don't normally modify value arguments
            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Her legger vi inn ref i både funksjon og kallet");
            Console.WriteLine("--------------------------------------");


            // TODO: Using the "ref" keyword, arguments can be passed by reference
            // which allows the function to modify them
            TestFunc2(ref val1);
            Console.WriteLine($"{val1}");

            Console.WriteLine("---------------------------");


            // TODO: The "out" keyword can be used to indicate that an argument
            // is intended to return a value and is not an input
            // a blir 40 fordi man tidligere endret den fra 10 til 20.
            // Dette er visst avleggs måten å gjøre det på.
            int a, b;
            TestFunc3(val1, val2, out a, out b);
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
}
