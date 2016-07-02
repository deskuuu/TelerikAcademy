namespace _01.Shapes
{
    using System;

    public class Square : Shape
    {
        //Define class Square and suitable constructor so that at 
        //initialization height must be kept equal to width and implement the CalculateSurface() method.
        public Square(decimal width, decimal height) : base(width, height)
        {
            if (height == width)
            {
                this.Height = height;
                this.Width = width;
            }
            else
            {
                throw new ArgumentException("Height and width must be equals.");
            }
     
        }

        public override void CalculateSurface()
        {
            var surface = Height * Width;
            Console.WriteLine($"Square surface: {surface}");
        }
    }
}
