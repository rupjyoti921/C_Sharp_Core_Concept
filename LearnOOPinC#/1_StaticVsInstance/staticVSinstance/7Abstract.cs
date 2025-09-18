using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice.Abstract
{
    public abstract class Person
    {
        public string name=string.Empty;
        public abstract int age { get; set; }
        public string phoneNum=string.Empty;
        public abstract void PrintDetails();
    }

    class Student:Person
    {
        int roll;
        string std;
        public override int age { get; set; }
        public Student(int ro, string st, string na, int ag, string phN)
        {
            roll = ro;
            std = st;
            name = na;
            age = ag;
            phoneNum = phN;   
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Student Name : {name} \nAge : {age} \nRoll Number : {roll} \nStandard : {std} \nPhone Number : {phoneNum}");
        }
    }

    class Teacher : Person
    {
        int id;
        string qualification;
        public override int age { get; set; }

        public Teacher(int iD, string qua, string na, int ag, string phN)
        {
            id = iD;
            qualification = qua;
            name = na;
            age = ag;
            phoneNum = phN;
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Teacher Name : {name} \nAge : {age} \nID Number : {id} \nQualification : {qualification} \nPhone Number : {phoneNum}");
        }
    }

    public class _7Abstract
    {
        public static void Main7()
        {
            Student st1 = new Student(12, "11th", "Rohan Das", 18, "9101109899");
            Teacher te1 = new Teacher(1002, "Master's", "Ramanu K.T.", 45, "7121109899");
            st1.PrintDetails();
            te1.PrintDetails();
        }
    }
}
