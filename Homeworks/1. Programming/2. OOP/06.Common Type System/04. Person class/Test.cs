namespace _04.Person_class
{
    using System;

    class Test
    {
        static void Main()
        {
            var person = new Person("She", 8);
            var personWithougtAge = new Person("He");

            Console.WriteLine(person.ToString());
            Console.WriteLine(personWithougtAge.ToString());
        }
    }
}
