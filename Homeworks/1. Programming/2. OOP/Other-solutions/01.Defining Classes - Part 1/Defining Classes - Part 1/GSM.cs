namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        public static readonly GSM Iphone4S = new GSM("IPhone4S", "Apple", "Desi", 100m);
        public List<Call> CallHistoryField = new List<Call>();

        private const decimal MinMobbilePrice = 100;
        private static readonly decimal PricePerMinute = 0.37M;

        private Battery battery;
        private Display display;

        // model, manufacturer, price, owner
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price = null) : this(model, manufacturer)
        {
            this.price = price;
        }

        public GSM(string model, string manufactorer, string owner, decimal? price = null) : this(model, manufactorer, price)
        {
            this.owner = owner;
        }

        public GSM(string model, string manufactorer, string owner, Battery battery, decimal? price = null)
            : this(model, manufactorer, owner, price)
        {
            this.battery = battery;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery batterry, Display display) :
            this(model, manufacturer, owner, batterry, price)
        {
            this.display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return Iphone4S;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(this.model))
                {
                    throw new ArgumentNullException("You should enter a phone model.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(this.manufacturer))
                {
                    throw new ArgumentNullException("You should enter a manufacturer!");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price < MinMobbilePrice)
                {
                    throw new ArgumentOutOfRangeException("The mobille price cannot be less than 100$.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (string.IsNullOrEmpty(this.owner))
                {
                    throw new ArgumentNullException("The mobille phone must has owner.");
                }
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.CallHistoryField;
            }

            set
            {
                this.CallHistoryField = value;
            }
        }

        public void AddCall(Call call)
        {
            this.CallHistoryField.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistoryField.Remove(call);
        }

        public void ClearCalls()
        {
            this.CallHistoryField.Clear();
        }

        public decimal? CallPrice()
        {
            var callPrice = 0M;

            for (int i = 0; i < this.CallHistoryField.Count; i++)
            {
                callPrice += this.CallHistoryField[i].Duration;
            }

            callPrice = (callPrice / 0.60M) * PricePerMinute;

            return callPrice;
        }

        public override string ToString()
        {
            var stb = new StringBuilder();

            stb.AppendLine($"Model: {this.model}");
            stb.AppendLine($"Manufacturer: {this.manufacturer}");

            if (this.owner != null)
            {
                stb.AppendLine($"Owner: {this.owner}");
            }

            stb.AppendLine($"Price: {this.price}");

            return stb.ToString();
        }
    }
}
