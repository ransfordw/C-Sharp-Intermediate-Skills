using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Ransford";

            Console.WriteLine(cookie["name"]);
        }
    }
}
// An indexer is declared much like you declare a property.
