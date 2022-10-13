using System;
namespace ConsoleApplication1
{
    // Base class
    class GFG
    {
        // data members
        public string name;
        public string subject;
        // public method of base class
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }
    // inheriting the GFG class using :
    class GeeksforGeeks : GFG
    {
        // constructor of derived class
        public GeeksforGeeks()
        {
            Console.WriteLine("Inheritance");
        }
    }
    // Driver class
    class Sudo
    {
        // Main Method
        static void Main(string[] args)
        {
            // creating object of derived class
            GeeksforGeeks g = new GeeksforGeeks();
            // calling the method of base class
            // using the derived class object
            g.readers("AliZainal", "C#");
        }
    }
}