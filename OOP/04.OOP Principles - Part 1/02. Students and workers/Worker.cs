namespace _02.Students_and_workers
{
     using Systems;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary,int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Invalid week salary.");
                }
                weekSalary = value;
            }
        }
        
        public int WorkHoursPerDay
        {
            get
            {
                return WorkHoursPerDay;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Works hour must be greather than 1.");
                }
                WorkHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return WeekSalary / WorkHoursPerDay;
        }
    }
}
