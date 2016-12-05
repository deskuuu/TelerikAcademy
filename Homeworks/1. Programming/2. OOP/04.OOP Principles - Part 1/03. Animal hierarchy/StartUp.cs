namespace _3.Animal_hierarchy
{
    using System;
    using _3.Animal_hierarchy.Animals;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            //Create arrays of different kinds of animals and calculate 
            //the average age of each kind of animal using a static method (you may use LINQ).

            var animals = new List<Animal>() {
                new Dog(2,"Sharo",SexType.Male),
                new Cat(5,"Maca",SexType.Female),
                new Frog(1,"CrazyFrog",SexType.Male),
                new Kitten(3,"Kitty"),
                new Tomcat(6,"TommyCat"),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }

            var average = animals.Average(a=>a.Age);
            Console.WriteLine($"Average {average}");
        }
    }
}
