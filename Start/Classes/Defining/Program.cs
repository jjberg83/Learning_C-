using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("Coding for old folks", "Jørund Jenssen Berg", 310);
            Book b2 = new Book("How to become a natural coder", "Benjamin Foldøy Grimstad", 28);
            
            // TODO: Call a method on the object
            Console.WriteLine(b1.DescribeBook());
            Console.WriteLine(b2.DescribeBook());

            // TODO: try to set one of the properties -- 
            // this will result in an error
            try 
            {
                b1._author = "Audun Jenssen Berg";
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
