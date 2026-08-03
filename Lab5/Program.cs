namespace Lab5;

class Program
{
    static void Main(string[] args)
    //Step 3 – Test in Main
    {
    Animal myAnimal = new Animal();
    Animal myCat = new Cat();
    Animal myDog = new Dog();

    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();}

    // Step 1 – Create a Base Class
    class Animal // Base class (parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    // Step 2 – Create Derived Classes
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: meow");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}