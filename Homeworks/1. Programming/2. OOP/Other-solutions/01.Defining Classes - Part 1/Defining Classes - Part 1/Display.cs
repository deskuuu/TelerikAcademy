namespace Defining_Classes___Part_1
{
    using System;

    public class Display
    {
        // display characteristics (size and number of colors)
        private const int MinSize = 14;
        private const int MinColors = 2;

        private int size;
        private int numberOfColors;

        public Display(int size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (this.size < MinSize)
                {
                    throw new ArgumentOutOfRangeException("The display size should be greather than min display size(10px)");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (this.numberOfColors < MinColors)
                {
                    throw new IndexOutOfRangeException("Invalid parameter of counter colors.");
                }

                this.numberOfColors = value;
            }
        }
    }
}
