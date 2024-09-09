using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Undefined sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.MakeSound(); 
        myCat.MakeSound();  
    }
}
