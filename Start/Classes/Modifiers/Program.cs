using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new Book instance
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // In previous example, this would fail, but will now
            // work since the field name is declared as public
            b1._name = "Cat in the Hat";
            Console.WriteLine(b1.GetDescription());

            // TODO: set data using functions instead of accessing fields directly
            Console.WriteLine(b1.GetName());

            b1.SetName("Excuse me, I think you might be wrong, good sir...");
            Console.WriteLine(b1.GetDescription());

            b1.SetAuthor("Jørund Jenssen Berg");
            Console.WriteLine(b1.GetDescription());

            b1.SetPageCount(400);
            Console.WriteLine(b1.GetDescription());

        }
    }
}
