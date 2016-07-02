namespace _01.Shapes
{
    public abstract class Shape
    {
        //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.

        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Shape(decimal width,decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract void CalculateSurface();
    }
}
