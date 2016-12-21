namespace Defining_Classes___Part_1
{
    using System;

    public class Battery
    {
        // battery characteristics (model, hours idle and hours talk)
        private const int MinhoursIdleTalk = 0;

        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        // constructor
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        // properties
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
                    throw new ArgumentNullException("Please, enter a valid phonemodel!");
                }

                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (this.hoursIdle < MinhoursIdleTalk)
                {
                    throw new ArgumentOutOfRangeException("Hours idle cannot be less than 0.");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (this.hoursTalk < MinhoursIdleTalk)
                {
                    throw new ArgumentOutOfRangeException("Hours talk cannot be less than 0.");
                }
            }
        }
    }
}
