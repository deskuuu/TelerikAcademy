namespace Variables_Data_Expressions_and_Constants
{
    using System;

    public class SizeInPixels
    {
        public SizeInPixels(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Invalid input numbers!");
            }

            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static SizeInPixels GetRotatedSize(SizeInPixels sizeToRotate, double angle)
        {
            var rotatedWidth = (Math.Abs(Math.Cos(angle)) * sizeToRotate.Width) +
                   (Math.Abs(Math.Sin(angle)) * sizeToRotate.Height);

            var rotatedHeght = (Math.Abs(Math.Sin(angle)) * sizeToRotate.Width) +
                    (Math.Abs(Math.Cos(angle)) * sizeToRotate.Height);

            var rotatedSize = new SizeInPixels(rotatedWidth, rotatedHeght);

            return rotatedSize;
        }
    }
}
