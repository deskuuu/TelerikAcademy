namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        //Fields
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        //static field for iPhone
        private static GSM iPhone4S;

        //Constructors
        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        //Properties
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public  static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        static GSM()
        {
            iPhone4S = new GSM("Iphone 4S", "Apple", 2000.00, "Kitty");
        }
       
        public List<Call> CallHistory = new List<Call>();

        //Methods
        public override string ToString()
        {
            Console.WriteLine("GSM model: {0}\nGSM manufacture: {1}\nGSM price: {2}$\nGSM owner: {3}", model, manufacturer, price, owner);
            Console.WriteLine("----------------");
            return base.ToString();
        }

        public void AddCalls(DateTime date, string dialedPhoneNumber, int duration)
        {
            Call call = new Call(date, dialedPhoneNumber, duration);
            CallHistory.Add(call);
        }

        public void DeleteCalls(int duration)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Duration == duration)
                {
                    CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearCalls()
        {
            CallHistory.Clear();
        }

        public void CalculateFinalPrice(double minutePrice)
        {
            double time = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                time += CallHistory[i].Duration;
            }

            double price = minutePrice * (time / 0.60);
            Console.WriteLine("Total price: {0:F2}$", price);
            Console.WriteLine("----------------");
        }

        public void PrintCalls()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Console.WriteLine("Date and Time: {0}\nDialed phone number: {1}\nDuration: {2}", CallHistory[i].Date, CallHistory[i].DialedPhoneNumber, CallHistory[i].Duration);
                Console.WriteLine("----------------");
            }
        }
    }
}