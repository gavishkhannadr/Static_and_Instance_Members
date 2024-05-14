using System;

namespace Static_and_Instance_Members
{

    class student
    {
        // Instance Member of Class 
        // they have a different variable for each  object of the class
        public int Id;
        public string Name;
        public int Standard;


        // Static Member of class 
        // Have the same value for the all objects of the class
        // it always used with the class name refer to line -> 37 
        // student.SchoolName f 
        public static string SchoolName = "ABC SCHOOL";



    }
    class Program
    {

        static void Main(string[] args)
        {
            student s1 = new student();
            s1.Id = 1;
            s1.Name = "Test";
            s1.Standard = 12;


            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Standard);
            Console.WriteLine(s1.Id);
            Console.WriteLine(student.SchoolName);

        }
    }
}