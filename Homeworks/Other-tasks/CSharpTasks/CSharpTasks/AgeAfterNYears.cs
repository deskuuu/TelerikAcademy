namespace CSharpTasks
{
    using System;

    class AgeAfterNYears
    {
        static void Main()
        {
            const int AfterYearYears = 10;

            var birthDate = Console.ReadLine();
            var currentAge = CalculateCurrentAge(birthDate);
            var afterTenYears = currentAge + AfterYearYears;

            Console.WriteLine($"{currentAge}\n{afterTenYears}");
        }

        private static int CalculateCurrentAge(string birthDate)
        {
            var currentAge = 0;
            // 09.05.2016 => date format
            if (string.IsNullOrEmpty(birthDate))
            {
                throw new ArgumentNullException("Missing input!");
            }

            try
            {
                var birtDayDate = DateTime.Parse(birthDate);
                var currentYear = DateTime.Now;
                currentAge = currentYear.Year - birtDayDate.Year;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input format date!Must be like 09.05.2016");
            }
            catch (Exception msg)
            {
                throw new Exception(msg.Message);
            }

            return currentAge;
        }
    }
}
