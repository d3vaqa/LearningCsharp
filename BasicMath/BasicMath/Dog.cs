using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine(Name + "says: Woof! Woof!");
        }

        public void Fetch(string thing)
        {
            Console.WriteLine($"{Name} fetched the {thing}");
        }

    }
}
