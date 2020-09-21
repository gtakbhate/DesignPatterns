using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        /*https://dotnettutorials.net/lesson/abstract-factory-design-pattern-csharp/

        “The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories 
        that have a common theme without specifying their concrete classes“.

        In simple words we can say, the Abstract Factory is a super factory that creates other factories. 
        This Factory is also called Factory of Factories.

        Abstract Factory Pattern provides an interface for creating families of related dependent objects 
        without specifying their concrete classes.
        The Abstract Factory Pattern provides a way to encapsulate a group of individual factories that 
        have a common theme without specifying their concrete classes.
        The abstract factory design pattern is merely an extension to the factory method pattern or factory pattern,
        which allows you to create objects without being concerned about the actual class of the object being created.
        Abstract means hiding some information and factory means which produces the products and pattern means 
        a design. So, the Abstract Factory Pattern is a software design pattern that provides a way to encapsulate
        a group of individual factories that have a common theme.

        */

        static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);

            Console.Read();
        }

    }
}
