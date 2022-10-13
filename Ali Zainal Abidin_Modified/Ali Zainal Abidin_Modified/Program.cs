using System;
namespace publicAccessModifier
{
    class Student
    {
        // Declaring members rollNo
        // and name as public
        public int rollNo;
        public string name;
        // Constructor
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }
        // methods getRollNo and getName
        // also declared as public
        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            // Creating object of the class Student
            Student S = new Student(1, "AliZainal");
            // Displaying details directly
            // using the class members
            // accessible through another method
            Console.WriteLine("Roll number: {0}", S.rollNo);
            Console.WriteLine("Name: {0}", S.name);
            Console.WriteLine();
            // Displaying details using
            // member method also public
            Console.WriteLine("Roll number: {0}", S.getRollNo());
            Console.WriteLine("Name: {0}", S.getName());
        }
    }
}