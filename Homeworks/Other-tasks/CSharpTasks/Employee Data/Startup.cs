namespace Employee_Data
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Models;
    using Types;

    class Startup
    {
        static void Main()
        {
            var employees = new List<IEmployee>(){
                new Employee("Desi","Kon",20,GenderType.Female,"12des"),
                new Employee("Anna","Koi",20,GenderType.Female,"12ann"),
                new Employee("Suzan","Koii",20,GenderType.Female,"12suze")
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
