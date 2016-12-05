namespace _01.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(decimal width,decimal height):base(width,height)
        {

        }

        public override void CalculateSurface()
        {
            var surface = Height * Width;
            System.Console.WriteLine($"Rectangle surface: {surface}");
        }
    }
}
