using System;

namespace MethodOverriding
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public static void Main(string[] args)
        {
            Dog leo = new Dog();
            leo.Eat();
            Console.ReadLine();
        } 
    }
}
