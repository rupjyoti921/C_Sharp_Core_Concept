using System.ComponentModel.DataAnnotations;
namespace CshOOPPractice
{
    class Student
    {
        int rollNo;
        string name;
        int age;
        public static string clgName = "NERIST";


        public Student(int Roll, string Name, int Age)   //Parameterized Constructor
        {
            rollNo = Roll;
            name = Name;
            age = Age;
        }
        public Student(Student std)   //COPY Constructor
        {
            rollNo = std.rollNo;
            name = std.name;
            age = std.age;
        }

        public void Display()
        {
            Console.WriteLine($"Name {name}, roll no {rollNo}, age is {age} and College is : {clgName}\n");
        }

        public static void Disp()
        {
            Console.WriteLine($"This is a Static Method.\t and Static Variable clgName value is : {clgName}.");
        }
    }


    class Program
    {
        public static void Main2()
        {
            Student st1 = new Student(Name: "Rahul", Age: 19, Roll: 12);
            Student st2 = new Student(st1);
            st1.Display();
            Student.clgName = "NEHU";
            st2.Display();
            Student.Disp();
        }
    }
}