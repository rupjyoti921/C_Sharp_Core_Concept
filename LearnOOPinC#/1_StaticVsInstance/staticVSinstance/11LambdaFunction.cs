using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CshOOPPractice
{
    public class Person
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
    }
    public class Lambda
    {
        public static void Main11()
        {
            List < Person > people= new List<Person>()
            {
                new Person("Rup", 33),
                new Person("Tanu", 45)
            };

            var minAge=people.Min(a=> a.Age);
            Console.WriteLine($"Minimum age is : {minAge}");

            List<int> nums=new List<int>() { 1, 2, 3, 4 };
            var sum=nums.Select(x=>x+x);
            Console.WriteLine(sum.Sum());

            //using Lambda in delegate. A delegate is which holds the fun reference.
            var a = 4;
            Func<int, int> Add = x => x + x;
            Console.WriteLine($"{a} + {a} =  {Add(3)}");

            //Func<int, int, int(return type)> "Delegate_var_Name"  - this is a build in Delegate
            //Func is just a container for a method (delegate).
            //It can represent any function that:
            //Takes 0–16 input parameters.
            //Always returns one value(the last generic type is the return type).
            //So any kind of operation(mathematical, string, object, LINQ, etc.) can be represented with Func.

            var name = "rupjyoti";
            Func<string, string> toUpp = x => x.ToUpper();
            Console.WriteLine($"Name in Upper Case :{toUpp(name)}");

            // Same method with out Delegate Lambda Only
            var b = 4;
            int Addition(int x)=>x+x;
            Console.WriteLine($"Lambda only-\n{b} + {b} =  {Addition(b)}");

            var name1 = "rupjyoti";
            string toUpper(string x) => x.ToUpper();
            Console.WriteLine($"Name in Upper Case :{toUpper(name1)}");
        }
    }
}
