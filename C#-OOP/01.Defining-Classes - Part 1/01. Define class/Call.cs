namespace MobilePhone
{
    using System;

    public class Call
    {
        //Fields
        private DateTime date;
        private string dialedPhoneNumber;
        private int duration;

        //Constructors
        public Call(DateTime date, string dialedPhoneNumber, int duration)
        {
            this.date = date;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        //Properties
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string DialedPhoneNumber
        {
            get { return dialedPhoneNumber; }
            set { dialedPhoneNumber = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}