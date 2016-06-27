namespace _03.First_before_last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestUp
    {
        static void Main()
        {
            Student[] arrStudents = {
                new Student("Eminem", "Eminemus", 30) ,
                new Student("Denis", "Kenzo", 30),
                new Student("Somebody", "Ashov", 10),
                new Student("Ivan", "Somename", 38),
                new Student("Klica", "Genkova", 5),
                new Student("Alex", "Genkov", 18),
                new Student("Darina", "Peteva", 23) };
            //Write a method that from a given array of students finds 
            //all students whose first name is before its last name alphabetically.
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by first name before last name:");
            Console.BackgroundColor = ConsoleColor.Black;
            var firstBeforeLastName = arrStudents
                  .Where(s => string.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0);

            PrintStudents(firstBeforeLastName);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students array ordered by age:");
            //Write a LINQ query that finds the first name and last name of all students with 
            //age between 18 and 24.
            var betweenEighteenAge = from student in arrStudents
                                     where (student.Age >= 18 && student.Age <= 24)
                                     select student;

            Console.BackgroundColor = ConsoleColor.Black;
            PrintStudents(betweenEighteenAge);
            //Using the extension methods OrderBy() and ThenBy() 
            //with lambda expressions sort the students by first name and last name in descending order.
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students array ordered by descending order:");
            var descendingSort = arrStudents.OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);

            Console.BackgroundColor = ConsoleColor.Black;
            PrintStudents(descendingSort);

            // With Linq
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students array ordered by descending order with Linq:");
            var descendingSortLinq = from student in arrStudents
                                     orderby student.FirstName descending, student.LastName descending
                                     select student; 

            Console.BackgroundColor = ConsoleColor.Black;
            PrintStudents(descendingSortLinq);
        }

        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
