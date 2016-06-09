namespace MobilePhone
{
    using System;

    class Battery
    {
        //Enumeration
        public enum BatteryType
        {
            LiIon, NiMH, NiCd, iMah
        }

        //Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        //Constructors
        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        //Properties
        public BatteryType BatteryModel // get from enumeration
        {
            get { return BatteryModel; }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
    }
}
