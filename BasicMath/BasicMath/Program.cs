// Tells the computer to use a collection of basic functions provided by C#
using System;


// namespace is like a container for our program 
namespace BasicMath

{
    // Think of a class as a blueprint. Here, Program is a blueprint for a tiny program we’re making.
    class Program
    {
        //This line defines a function named Main. 
        static void Main(string[] args)
        {

            Dog myDog = new Dog();
            myDog.Name = "Rex";
            myDog.Color = "Brown";

            myDog.Bark();
            myDog.Fetch("Ball");
            
        }
    }
}
