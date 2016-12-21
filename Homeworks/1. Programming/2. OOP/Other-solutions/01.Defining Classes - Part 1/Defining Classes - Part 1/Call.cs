namespace Defining_Classes___Part_1
{
    using System;
    using System.Text;

    public class Call
    {
        // It should contain date, time, dialled phone number and duration (in seconds).
        private DateTime date;
        private string time;
        private string dialledNumber;
        private decimal duration;

        public Call(DateTime date, string time, string dialledNumber, decimal duration)
        {
            this.date = date;
            this.time = time;
            this.dialledNumber = dialledNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }

            set
            {
                if (string.IsNullOrEmpty(this.time))
                {
                    throw new ArgumentOutOfRangeException("This time is invalid!");
                }

                this.time = value;
            }
        }

        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(this.dialledNumber))
                {
                    throw new ArgumentNullException("Dialled number is missing!");
                }

                this.dialledNumber = value;
            }
        }

        public decimal Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                if (this.duration < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration time cannot be less than 0!");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            var stb = new StringBuilder();
            if (this.date != null)
            {
                stb.AppendLine($"Date: {this.date}");
            }

            if (this.time != null)
            {
                stb.AppendLine($"Time: {this.time}");
            }

            if (this.dialledNumber != null)
            {
                stb.AppendLine($"Dialled phone number: {this.dialledNumber}");
            }

            if (this.duration != 0)
            {
                stb.AppendLine($"Duration: {this.duration}");
            }

            return stb.ToString();
        }
    }
}
