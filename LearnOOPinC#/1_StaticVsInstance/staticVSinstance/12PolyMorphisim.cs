using CshOOPPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------- With Polymorphisim-------

namespace CshOOPPractice
{
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("Animal Voice");
        }
    }
    public class Dog:Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Dog: Vow Vow");
        }
    }

    public class Cat:Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cat: Meow Meow");
        }
    }

    public class Cow: Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cow: Hammaa Hammama");
        }
    }
    public class PolyMorphisim
    {
        public static void Main11()
        {
            //Animal animal = new Animal();     // Don't need all these 3 reference 3 method call
            //Dog dog = new Dog();      
            //Cat cat = new Cat();
            //Cow cow = new Cow();
            //dog.Voice();
            //cat.Voice();
            //cow.Voice();
            Animal animal = new Cow();  // make chagnges of only Cat/Dog/Cow
            AnimalVoice(animal);
            List<Animal> animals = new List<Animal>()
            {
                new Dog(),
                new Cat(),
                new Cow()
            };
            AnimalVoices(animals);
        }
        public static void AnimalVoice(Animal animal)=>animal.Voice();
        public static void AnimalVoices(List<Animal> animals)
        {
            foreach (var ani in animals)
            {
                ani.Voice();
            }
        }
    }
}

//Polymorphism in C# allows you to use a single base class reference (Animal) to call methods of any derived class (Dog, Cat, Cow, etc.) without changing your main code. Once you define the base class method as virtual and override it in child classes, the actual method that gets executed is decided at runtime based on the object assigned to the base reference. This means if you add a new animal in the future, you only need to create the new class and override the method — the existing logic, like your AnimalVoice() method, will automatically work without modification. This demonstrates the power of polymorphism and follows the OCP (Open/Closed Principle): the system is open to extension (adding new animals) but closed to modification (no need to rewrite old code).


//--------  Normal Without Polymorphisim-------------

//namespace CshOOPPractice
//{
//    public class Dog
//    {
//        public void Voice()
//        {
//            Console.WriteLine("Dog: Vow Vow");
//        }
//    }

//    public class Cat
//    {
//        public void Voice()
//        {
//            Console.WriteLine("Cat: Meow Meow");
//        }
//    }

//    public class Cow
//    {
//        public void Voice()
//        {
//            Console.WriteLine("Cow: Hammaa Hammama");
//        }
//    }
//    public class PolyMorphisim
//    {
//        public static void Main()
//        {
//            Dog dog = new Dog();
//            Cat cat = new Cat();
//            Cow cow = new Cow();
//            dog.Voice();
//            cat.Voice();
//            cow.Voice();
//        }
//    }
//}
