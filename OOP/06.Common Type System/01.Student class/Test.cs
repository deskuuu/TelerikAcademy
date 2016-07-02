namespace _01.Student_class
{
    using System;

    class Test
    {
        static void Main()
        {
            var she = new Student("She", "middleShe", "Mrs.She", "45765", "Sofia Al.Malinov",
                "0888456788", "she@gmail.com", "C#", SpecialityType.Informatics, UniversityType.SofiaUniversity, FacultyType.Maths);

            var he = new Student("He", "middleHe", "Mr.He", "456765", "Sofia Al.Malinov",
               "0888434788", "he@gmail.com", "C#", SpecialityType.Authomatics, UniversityType.TechUniversity, FacultyType.Tech);

            var copyHer = she.Clone();
            copyHer = copyHer as Student;
            Console.WriteLine($"Copied her:");
            Console.WriteLine(copyHer);

            Console.WriteLine(she.ToString());
            Console.WriteLine(he.ToString());

            var isTheSame=she==he?"They are together :D":"They are in break.";
            Console.WriteLine(isTheSame);

            var code = she.GetHashCode() == he.GetHashCode() ? "The same codes." : "Different codes.";
            Console.WriteLine(code);

            var compared = she.CompareTo(he);
            Console.WriteLine($"Compared ? ==> {compared}");
        }
    }
}
