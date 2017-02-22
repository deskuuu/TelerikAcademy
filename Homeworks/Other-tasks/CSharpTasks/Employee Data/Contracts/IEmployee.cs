namespace Employee_Data.Contracts
{
    using Types;

    internal interface IEmployee
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        GenderType Gender { get; set; }

        string EmployeeNumber { get; set; }
    }
}