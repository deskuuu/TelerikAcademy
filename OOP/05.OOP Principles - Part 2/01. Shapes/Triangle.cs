namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(decimal width, decimal height) : base(width, height)
        {
        }

        //    Define two new classes Triangle and Rectangle that 
        //    implement the virtual method and return the surface of the figure
        //        (height* width/2 for triangle).
        public override void CalculateSurface()
        {
            var surface = (Height * Width) / 2;
            System.Console.WriteLine($"Triangle surface: {surface}");
        }
    }
}
