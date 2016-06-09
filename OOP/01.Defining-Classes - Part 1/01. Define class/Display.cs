namespace MobilePhone
{
    using System;

    class Display
    {
        //Fields
        private double size;
        private string numberOfColors;

        //Constructors
        public Display(double size, string numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        //Properties
        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public string NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }
}
