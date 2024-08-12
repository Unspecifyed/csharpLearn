using System;
using System.Linq;  // Ensure you're using System.Linq for the LINQ methods

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var triple = (int x) => x * 3;
        var range = Enumerable.Range(1, 3);
        var triples = range.Select(triple);

        Console.WriteLine(string.Join(", ", triples)); // Displaying the values in the triples collection
        Console.WriteLine("asdfasdfasd");
    }
}
