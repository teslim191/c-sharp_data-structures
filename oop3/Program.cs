using System;

namespace oop3
{
    class Person
    {
        public string Name
        {
            get; set;
        }

       /* public Person(string value)
        {
            Name = value;
        }*/
        public void eating(string name)
        {
            Console.WriteLine("{0} is eating",name);
        }
    }
    //inheritance
    class FirstPerson: Person
    {

    }

    class Animal
    {
        //to override the base class
        public virtual void animalSound()
        {
            Console.WriteLine("the animal made a sound");
        }

    }

    class Dog : Animal
    {
        //to allow the derived class override base class
        public override void animalSound()
        {
            Console.WriteLine("the dog is barking");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("the cat is meowing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person_1 = new Person();
            //person_1.Name = "john";

            //Console.WriteLine(person_1.Name);

            FirstPerson f_person = new FirstPerson();
            f_person.Name = "john";
            f_person.eating("tayo");

            Animal animal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myCat.animalSound();
        }
    }
}
