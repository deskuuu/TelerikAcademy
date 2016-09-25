namespace _09.Student_groupss
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestStudent
    {
        static void Main()
        {
            //Create a List<Student> with sample students. Select only the students that are from group number 2.
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", "Peshev", "012006", "02/123412", "pesho@abv.bg", new List<int>() { 2, 3, 5, 5, 6, 6, 2 }, 2));
            students.Add(new Student("Gosho", "Peshev", "022008", "02/125412", "gosho@gmail.com", new List<int>() { 3, 2}, 4));
            students.Add(new Student("Stamat", "Todorov", "032006", "12/121212", "stamat@yahoo.com", new List<int>() { 2, 2, 3, 5 }, 2));
            students.Add(new Student("Asparuh", "Dimitrov", "042007", "34/123442", "asparuh@abv.bg", new List<int>() { 2, 2}, 3));

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by group number 2:");
            Console.BackgroundColor = ConsoleColor.Black;

            var studentsFromGroupTwo = students.Where(s => s.GroupNumber == 2).ToList();
            Print(studentsFromGroupTwo);

            //Use LINQ query.Order the students by FirstName.
            var orderByFirstName = from student in students
                                   orderby student.FirstName
                                   select student;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by first name with extenssion methods:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var student in orderByFirstName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by first name with Linq:");
            Console.BackgroundColor = ConsoleColor.Black;

            var orderByFirstNameLinq = students.OrderBy(s => s.FirstName);
            foreach (var student in orderByFirstNameLinq)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            //Extract all students that have email in abv.bg.
            var inAbv = from student in students
                        where student.Email.IndexOf("abv.bg") != -1
                        select student;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by abv mail:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var student in inAbv)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Email}");
            }

            //Extract all students with phones in Sofia.
            var inSofiq = from student in students
                          where student.Tel.StartsWith("02/")
                          select student;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by Sofiq numbers:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var student in inSofiq)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Tel}");
            }

            //Select all students that have at least one mark Excellent (6)
            var excellentMarks = from student in students
                                 where student.Marks.IndexOf(6) != -1
                                 select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by Excellent marks:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var student in excellentMarks)
            {
                Console.WriteLine("{0} [{1}]", student.FullName, string.Join(", ", student.Marks));
            }

            //Write down a similar program that extracts the students with exactly two marks "2".
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by 2 marks:"); 
            Console.BackgroundColor = ConsoleColor.Black;
            var withTwoMarks = students
                .Where(s => s.Marks.Count() == 2)
                .Select(s=> new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });

            foreach (var student in withTwoMarks)
            {
                Console.WriteLine("{0} [{1}]", student.FullName, string.Join(", ", student.Marks));
            }

            //Extract all Marks of the students that enrolled in 2006.
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by 2006 enroleld:");
            Console.BackgroundColor = ConsoleColor.Black;
            var enrolled = students
                .OrderBy(s => s.FN.LastIndexOf("06"))
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, FN = s.FN });

            foreach (var student in enrolled)
            {
                Console.WriteLine($"{student.FullName} {student.FN}");
            }

            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by groupNumber with extenssions:");
            Console.BackgroundColor = ConsoleColor.Black;
            var byGroupNumber = students
                .OrderBy(s => s.GroupNumber).ToList();

            Print(byGroupNumber);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students list ordered by groupNumber with Linq:");
            Console.BackgroundColor = ConsoleColor.Black;
            var byGroupNumberLinq = from student in students
                                    orderby student.GroupNumber
                                    select student;
            foreach (var student in byGroupNumberLinq)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.GroupNumber}");
            }
        }

        static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.GroupNumber}");
            }
        }
    }
}
