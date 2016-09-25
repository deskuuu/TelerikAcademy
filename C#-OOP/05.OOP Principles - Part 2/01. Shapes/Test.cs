namespace _01.Shapes
{
    class Test
    {
        static void Main()
        {
            //Write a program that tests the behaviour of the CalculateSurface() 
            //method for different shapes (Square, Rectangle, Triangle) stored in an array.
            var square = new Square(12, 12);
            var rectangle = new Rectangle(13, 60);
            var triangle = new Triangle(13, 10);

            var shapes = new Shape[] { square, rectangle, triangle };
            foreach (var shape in shapes)
            {
                shape.CalculateSurface();
            }
        }
    }
}
