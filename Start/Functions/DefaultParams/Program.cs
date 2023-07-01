using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix="")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters

PrintWithPrefix("Jørund ruler");
PrintWithPrefix("Jørund ruler", "//");


// TODO: Call with named params
PrintWithPrefix(prefix: "------------------------------------>", thestr: "Hello, World!");
