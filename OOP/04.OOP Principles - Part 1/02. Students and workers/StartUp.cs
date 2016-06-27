namespace _02.Students_and_workers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() 
            //extension method).
            var students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 5),
                new Student("Stamat", "Borisov", 3),
                new Student("Eminem", "Mitkov", 6),
                new Student("Galq", "Hristova", 2),
                new Student("Desi", "Manova", 3),
                new Student("Tina", "Borisova", 4),
                new Student("MAriq", "Niks", 2),
                new Student("Anna", "Marinova", 2),
                new Student("Stamat", "Dimitrov", 6),
                new Student("Hristo", "Peev", 5),
            };


            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students:");
            Console.BackgroundColor = ConsoleColor.Black;
            var sortedByAscendingOrder = students.OrderBy(s => s.Grade);
            foreach (var student in sortedByAscendingOrder)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} Grade:{student.Grade}");
            }

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var workers = new List<Worker>()
            {
                new Worker("Ivan", "Ivanov",560, 5),
                new Worker("Stamat", "Borisov", 700,8),
                new Worker("Eminem", "Mitkov", 690,6),
                new Worker("Galq", "Hristova",230, 12),
                new Worker("Desi", "Manova", 150,3),
                new Worker("Tina", "Borisova", 400,4),
                new Worker("MAriq", "Niks", 1200,20),
                new Worker("Anna", "Marinova",600, 12),
                new Worker("Stamat", "Dimitrov", 450,6),
                new Worker("Hristo", "Peev", 900,5),
            };

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Workers:");
            Console.BackgroundColor = ConsoleColor.Black;
            var sortedByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            foreach (var worker in sortedByMoneyPerHour)
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} Money per hour:{worker.MoneyPerHour():F2}");
            }

            //Merge the lists and sort them by first name and last name.
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Workers and students:");
            Console.BackgroundColor = ConsoleColor.Black;

            var people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            var sortedBoth = people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            foreach (var person in sortedBoth)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}